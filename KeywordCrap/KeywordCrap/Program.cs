using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeywordCrap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string arg="";
            if (args.Length>0)
                arg = args[0];
            MainForm frmMain = new MainForm(arg);
            Application.Run(frmMain);
            //Application.Run(new TestMainForm());
        }
    }
}