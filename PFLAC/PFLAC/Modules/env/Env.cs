using System;
using System.IO;
using System.Windows.Forms;

namespace PFLAC
{
    public static class Env
    {
        /*
        * @public
        *
        * @params {string status}
        */
        public static void GetFullPath(string status)
        {
            string[] directoriesToSearch;

            if (Path.DirectorySeparatorChar == '\\')
            {
                directoriesToSearch = new string[]
                {
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)), // User profile
                    "C:\\",
                    "D:\\"
                };
            }
            else
            {
                // Linux/OSX paths
                directoriesToSearch = new string[]
                {
                    "/home",
                    "/var", 
                    "/etc" 
                };
            }

            string searchPattern = string.IsNullOrEmpty(status) ? ".env" : $".env.{status}";

            foreach (var dir in directoriesToSearch)
            {
                try
                {
                    foreach (var file in Directory.EnumerateFiles(dir, searchPattern, SearchOption.AllDirectories))
                    {
                        ProcessFullPath(file);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                catch (Exception e)
                {
                    Messages.Error($"Немає доступу до папки: {dir}: {e.Message}");
                }
            }
        }

        /*
        *  @public
        *  
        *  @params {string file}
        */
        public static void ProcessFullPath(string file)
        {
            try
            {
                foreach (var line in File.ReadAllLines(file))
                {
                    var parts = line.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 2)
                    {
                        Environment.SetEnvironmentVariable(parts[0], parts[1]);
                    }
                }
            }
            catch (Exception e)
            {
                Messages.Error($"Помилка при обробці: {file}: {e.Message}");
            }
        }
    }
}
