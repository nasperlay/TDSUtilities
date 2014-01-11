﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CrystalReportsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string strSwitch)
        {
            if (strSwitch == "")
            {
                MessageBox.Show("The parameter is null");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}