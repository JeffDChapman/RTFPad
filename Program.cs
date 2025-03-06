using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RTFPad
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string startDoc = "";
            if (args.Length > 0) { startDoc = args[0]; }
            if (startDoc == "") { Application.Run(new rtfPadForm()); }
            else { Application.Run(new rtfPadForm(startDoc)); }
        }
    }
}