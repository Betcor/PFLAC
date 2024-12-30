using System;
using System.IO;
using System.Windows.Forms;

namespace PFLAC
{
    public static class DotEnv
    {
        /*
        * @public
        *
        * @params {string status}
        */
        public static void Load(string status)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $".env{(string.IsNullOrEmpty(status) ? "" : $".{status}")}");
            
            if (!File.Exists(filePath))
            {
                Messages.Error("Файл .env не знайдено!");
                return;
            }

           foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2)
                {
                    Environment.SetEnvironmentVariable(parts[0], parts[1]);
                }
            }

        }
    }
}

