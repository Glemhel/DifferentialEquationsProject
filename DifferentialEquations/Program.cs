﻿using System;
using System.Windows.Forms;

namespace DifferentialEquations
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // run the application
            Application.Run(new MainForm());
        }
    }
}
