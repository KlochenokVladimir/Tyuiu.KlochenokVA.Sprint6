using System;
using System.IO;
using System.Windows.Forms;

namespace Tyuiu.KlochenokVA.Sprint6.Task2.V27
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new FormMain());
            }
            catch (Exception ex)
            {
                try
                {
                    string logPath = Path.Combine(AppContext.BaseDirectory, "last_error.txt");
                    File.WriteAllText(logPath, ex.ToString());
                    MessageBox.Show($"Произошла непредвиденная ошибка. Подробности сохранены в:\r\n{logPath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    // If logging fails, still show minimal message
                    MessageBox.Show("Произошла непредвиденная ошибка и не удалось записать лог.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}