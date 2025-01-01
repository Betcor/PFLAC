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
      public static string GetFullPath(string status)
      {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $".env{(string.IsNullOrEmpty(status) ? "" : $".{status}")}");

        if (!File.Exists(filePath))
        {
          Messages.Error("Файл .env не знайдено!");
          return string.Empty;
        }

        foreach (var line in File.ReadAllLines(filePath))
        {
          var parts = line.Split('=', (char)StringSplitOptions.RemoveEmptyEntries);

          if (parts.Length == 2)
          {
            Environment.SetEnvironmentVariable(parts[0], parts[1]);
          }
        }

        return filePath;

      }
    }
}

