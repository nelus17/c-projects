using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace howto_hour_conversion_chart_word
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
