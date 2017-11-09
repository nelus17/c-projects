namespace howto_hour_conversion_chart_word
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTimeZone1 = new System.Windows.Forms.ComboBox();
            this.cboTimeZone2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeChart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Временная зона 1:";
            // 
            // cboTimeZone1
            // 
            this.cboTimeZone1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimeZone1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeZone1.FormattingEnabled = true;
            this.cboTimeZone1.Location = new System.Drawing.Point(355, 75);
            this.cboTimeZone1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboTimeZone1.Name = "cboTimeZone1";
            this.cboTimeZone1.Size = new System.Drawing.Size(735, 39);
            this.cboTimeZone1.Sorted = true;
            this.cboTimeZone1.TabIndex = 1;
            this.cboTimeZone1.SelectedIndexChanged += new System.EventHandler(this.cboTimeZone1_SelectedIndexChanged);
            // 
            // cboTimeZone2
            // 
            this.cboTimeZone2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimeZone2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeZone2.FormattingEnabled = true;
            this.cboTimeZone2.Location = new System.Drawing.Point(355, 157);
            this.cboTimeZone2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboTimeZone2.Name = "cboTimeZone2";
            this.cboTimeZone2.Size = new System.Drawing.Size(735, 39);
            this.cboTimeZone2.Sorted = true;
            this.cboTimeZone2.TabIndex = 3;
            this.cboTimeZone2.SelectedIndexChanged += new System.EventHandler(this.cboTimeZone2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Временная зона 2:";
            // 
            // btnMakeChart
            // 
            this.btnMakeChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMakeChart.Location = new System.Drawing.Point(492, 231);
            this.btnMakeChart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMakeChart.Name = "btnMakeChart";
            this.btnMakeChart.Size = new System.Drawing.Size(403, 55);
            this.btnMakeChart.TabIndex = 4;
            this.btnMakeChart.Text = "Рассчитать разницу";
            this.btnMakeChart.UseVisualStyleBackColor = true;
            this.btnMakeChart.Click += new System.EventHandler(this.btnMakeChart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 699);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1173, 699);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Разница во времени:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 32);
            this.label8.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Локальное время";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(596, 302);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 32);
            this.label11.TabIndex = 16;
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(38, 439);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(236, 240);
            this.picture1.TabIndex = 17;
            this.picture1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 699);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "label12";
            // 
            // picture2
            // 
            this.picture2.Location = new System.Drawing.Point(602, 439);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(225, 240);
            this.picture2.TabIndex = 19;
            this.picture2.TabStop = false;
            // 
            // picture3
            // 
            this.picture3.Location = new System.Drawing.Point(1114, 439);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(233, 240);
            this.picture3.TabIndex = 20;
            this.picture3.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMakeChart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 824);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMakeChart);
            this.Controls.Add(this.cboTimeZone2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTimeZone1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Мировое время";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTimeZone1;
        private System.Windows.Forms.ComboBox cboTimeZone2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMakeChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

