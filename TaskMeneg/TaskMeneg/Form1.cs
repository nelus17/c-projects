using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskMeneg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string T, p1,p2,p3;
        int i = 1;

        private void timer2_Tick(object sender, EventArgs e)
        {
         
            T = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            if (T == p1)
            {
                Process.Start(textBox1.Text);
                
            } else if (T == p2)
            {
                Process.Start(textBox2.Text);
            } else if (T == p3)
            {
                Process.Start(textBox3.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                button1.Text = "Выкючить таймер";
                timer2.Start();
                p1 = maskedTextBox1.Text;
                p2 = maskedTextBox2.Text;
                p3 = maskedTextBox3.Text;
                maskedTextBox1.Enabled = false;
                maskedTextBox2.Enabled = false;
                maskedTextBox3.Enabled = false;
                i = 2;
            }
            else{
                button1.Text = "Вкючить таймер";
                timer2.Stop();
                maskedTextBox1.Enabled = true;
                maskedTextBox2.Enabled = true;
                maskedTextBox3.Enabled = true;
                i = 1;
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
           textBox1.Text = openFileDialog1.FileName;
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox2.Text = openFileDialog1.FileName;
        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox3.Text = openFileDialog1.FileName;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)

            {

                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Переход в трей";

                notifyIcon1.BalloonTipText = "Программа продолжит свою работу из трея";

                notifyIcon1.ShowBalloonTip(5000);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Текущее время "+DateTime.Now.Hour.ToString("00")+":"+DateTime.Now.Minute.ToString("00") + ":"+DateTime.Now.Second.ToString("00");
           
        }
    }
}
