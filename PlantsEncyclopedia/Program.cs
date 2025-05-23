﻿using System;
using System.Windows.Forms;

namespace PlantsEncyclopedia
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Encyclopedia.LoadData();
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                Encyclopedia.SaveData();
                throw;
            }
            Encyclopedia.SaveData();
        }
    }
}
