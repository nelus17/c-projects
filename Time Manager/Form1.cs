using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace howto_hour_conversion_chart_word
{
    public partial class Form1 : Form
    {
        SizeF c;  // Ось стрелок
        PointF p0; // Короткий конец всех стрелок
        PointF pH; // Длинный конец часовой стрелки
        PointF pM; // Длинный конец минутной и секундной стрелок
        PointF pD0, pD1; // деление циферблата
        DateTime lastUpdate = DateTime.Now, time1,time2;
        SolidBrush s = new SolidBrush(Color.DarkGray);     
        public Form1()
        {
            InitializeComponent();
            c = new SizeF(picture1.Width / 2.0f, picture1.Height / 2.0f);
            float r = Math.Min(picture1.Width, picture1.Height) / 2.5f; 
            p0 = new PointF(0, -r * .2f); pH = new PointF(0, r * .5f);
            pM = new PointF(0, r * .9f);
            pD0 = new PointF(0, .8f * r); pD1 = new PointF(0, r);
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            foreach (TimeZoneInfo info in
                TimeZoneInfo.GetSystemTimeZones())
            {
                cboTimeZone1.Items.Add(info);
                cboTimeZone2.Items.Add(info);
            }

        }
        void DrawDash(Graphics g, Pen pen, PointF p0, PointF p1, float a)
        {
            float a1 = -(float)Math.Cos(a), b1 = (float)Math.Sin(a),
                a2 = -(float)Math.Sin(a), b2 = -(float)Math.Cos(a);
            g.DrawLine(pen,
               new PointF(p0.X * a1 + p0.Y * b1, p0.X * a2 + p0.Y * b2) + c,
                new PointF(p1.X * a1 + p1.Y * b1, p1.X * a2 + p1.Y * b2) + c);
        }

        private void SelectItemContaining(ComboBox cbo, string target)
        {
            foreach (object item in cbo.Items)
            {
                if (item.ToString().Contains(target))
                {
                    cbo.SelectedItem = item;
                    return;
                }
            }
            
        }        
        
        private void btnMakeChart_Click(object sender, EventArgs e)
        {
            DateTime timeLocal = DateTime.Now;
            TimeZoneInfo zoneLocal = TimeZoneInfo.Local;
            TimeZoneInfo zone1 = cboTimeZone1.SelectedItem as TimeZoneInfo;
            TimeZoneInfo zone2 = cboTimeZone2.SelectedItem as TimeZoneInfo;
            time1 = TimeZoneInfo.ConvertTime(timeLocal, zoneLocal, zone1);
            time2 = TimeZoneInfo.ConvertTime(timeLocal, zoneLocal, zone2);
            TimeSpan ts;
            if (time1 > time2)
            {
                ts = time1 - time2;
            }
            else
            {
                ts = time2 - time1;
            }
            this.label11.Text = string.Format("{0:00}:{1:00}", ts.Hours, ts.Minutes);

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime timeLocal = DateTime.Now;
            TimeZoneInfo zoneLocal = TimeZoneInfo.Local;
            TimeZoneInfo zone1 = cboTimeZone1.SelectedItem as TimeZoneInfo;
            time1 = TimeZoneInfo.ConvertTime(timeLocal, zoneLocal, zone1);
            this.label4.Text = time1.ToLongTimeString();
            Form1_Paint();

        }
        private void timer3_Tick(object sender, EventArgs e)
        {

            DateTime timeLocal = DateTime.Now;
            TimeZoneInfo zoneLocal = TimeZoneInfo.Local;
            TimeZoneInfo zone2 = cboTimeZone2.SelectedItem as TimeZoneInfo;
            time2 = TimeZoneInfo.ConvertTime(timeLocal, zoneLocal, zone2);
            this.label5.Text = time2.ToLongTimeString();
            Form1_Paint();
        }
        private void cboTimeZone1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime timeLocal = DateTime.Now;
            TimeZoneInfo zoneLocal = TimeZoneInfo.Local;
            TimeZoneInfo zone1 = cboTimeZone1.SelectedItem as TimeZoneInfo;
            time1 = TimeZoneInfo.ConvertTime(timeLocal, zoneLocal, zone1);

            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();

            if (timeLocal.Date < time1.Date) this.label4.Text += " (Завтра)";
            else if (timeLocal.Date > time1.Date) this.label4.Text += " (Вчера)";
        }
        private void cboTimeZone2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime timeLocal = DateTime.Now;
            TimeZoneInfo zoneLocal = TimeZoneInfo.Local;
            TimeZoneInfo zone2 = cboTimeZone2.SelectedItem as TimeZoneInfo;
            time2 = TimeZoneInfo.ConvertTime(timeLocal, zoneLocal, zone2);

            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Start();

            if (timeLocal.Date < time2.Date) this.label5.Text += " (Завтра)";
            else if (timeLocal.Date > time2.Date) this.label5.Text += " (Вчера)";
        }   
        private void Form1_Paint()
        {  //локальные часы
            Bitmap bmp = new Bitmap(picture1.Width, picture1.Height);
            Graphics g = Graphics.FromImage(bmp);
            DrawDash(g, new Pen(s, 10), pD0, pD1, 0);
            for (int ct = 1; ct < 12; ct++)
                DrawDash(g, new Pen(s, 3), pD0, pD1, ct * (float)Math.PI / 6.0f);
            DrawDash(g, new Pen(Brushes.Black, 4), p0, pH,
            (lastUpdate.Hour * 60f + lastUpdate.Minute) * (float)Math.PI / 360f);
            DrawDash(g, new Pen(Brushes.Black, 2), p0, pM, lastUpdate.Minute * (float)Math.PI / 30.0f);
            DrawDash(g, new Pen(Brushes.Red, 1), p0, pM, lastUpdate.Second * (float)Math.PI / 30.0f);
            picture1.Image = bmp;

            //первая временная зона
            Bitmap bmp2 = new Bitmap(picture2.Width, picture2.Height);
            Graphics g2 = Graphics.FromImage(bmp2);
            DrawDash(g2, new Pen(s, 10), pD0, pD1, 0);
            for (int ct = 1; ct < 12; ct++)
                DrawDash(g2, new Pen(s, 3), pD0, pD1, ct * (float)Math.PI / 6.0f);
            DrawDash(g2, new Pen(Brushes.Black, 4), p0, pH,
            (time1.Hour * 60f + time1.Minute) * (float)Math.PI / 360f);
            DrawDash(g2, new Pen(Brushes.Black, 2), p0, pM, time1.Minute * (float)Math.PI / 30.0f);
            DrawDash(g2, new Pen(Brushes.Red, 1), p0, pM, time1.Second * (float)Math.PI / 30.0f);
            picture2.Image = bmp2;

            //вторая временная зона
            Bitmap bmp3 = new Bitmap(picture3.Width, picture3.Height);
            Graphics g3 = Graphics.FromImage(bmp3);
            DrawDash(g3, new Pen(s, 10), pD0, pD1, 0);
            for (int ct = 1; ct < 12; ct++)
                DrawDash(g3, new Pen(s, 3), pD0, pD1, ct * (float)Math.PI / 6.0f);
            DrawDash(g3, new Pen(Brushes.Black, 4), p0, pH,
            (time2.Hour * 60f + lastUpdate.Minute) * (float)Math.PI / 360f);
            DrawDash(g3, new Pen(Brushes.Black, 2), p0, pM, time2.Minute * (float)Math.PI / 30.0f);
            DrawDash(g3, new Pen(Brushes.Red, 1), p0, pM, time2.Second * (float)Math.PI / 30.0f);
            picture3.Image = bmp3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1_Paint();
            if (DateTime.Now - lastUpdate > TimeSpan.FromSeconds(1)) { lastUpdate = DateTime.Now; Invalidate(); }
            label12.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

    }
}
