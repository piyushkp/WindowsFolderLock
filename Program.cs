using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FolderLocking
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
            folderLock f = new folderLock();
            if (args.Length > 0)
                f.pathkey = args[0];
            Application.Run(f);
        }
    }
}