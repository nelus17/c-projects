using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;


namespace SearchThis
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = Color.Black;
            string str = textBox1.Text;
            int i = 0;
            while (i <= richTextBox1.Text.Length - str.Length)
            {
                i = richTextBox1.Text.IndexOf(str, i);
                if (i < 0) break;
                richTextBox1.SelectionStart = i;
                richTextBox1.SelectionLength = str.Length;
                richTextBox1.SelectionColor = Color.Red;
                i += str.Length;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                richTextBox1.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = Color.Black;
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                richTextBox1.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = Color.Black;
            textBox1.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = Color.Black;
            string str = textBox1.Text;
            int i = 0;
            while (i <= richTextBox1.Text.Length - str.Length)
            {
                i = richTextBox1.Text.IndexOf(str, i);
                if (i < 0) break;
                richTextBox1.SelectionStart = i;
                richTextBox1.SelectionLength = str.Length;
                richTextBox1.SelectionColor = Color.Red;
                i += str.Length;
            }
        }


        public static void Find(WebBrowser webBrowser, string searchString)
        {
            // you can add check page load complette, if needed
            IHTMLDocument2 document = webBrowser.Document?.DomDocument as IHTMLDocument2;
            IHTMLTxtRange range = document?.selection.createRange() as IHTMLTxtRange;
            if (range == null) return;

            if (!range.findText(searchString)) return;

            // select
            range.@select();
            // make highlighted
            range.pasteHTML("<span id='i-am-selected' style='background-color: rgb(255, 255, 0);'>"
                             + searchString + "</span>");

            // and i want see find result on top of page
            // 1. scroll to page end
            webBrowser.Document.Body?.ScrollIntoView(false);
            // 2. scroll to find result
            range.scrollIntoView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Find(webBrowser1, textBox3.Text);
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + textBox2.Text);
        }
    }
    }

