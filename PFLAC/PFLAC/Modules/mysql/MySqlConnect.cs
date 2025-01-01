using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PFLAC
{
  class MySqlConnect
  {
    /*
    * @private
    *
    * @params {string path}
    */
    private async Task Connect()
    {
      string dbUser = Environment.GetEnvironmentVariable("DB_USER");
      string dbPass = Environment.GetEnvironmentVariable("DB_PASS");

      string dbName = Environment.GetEnvironmentVariable("DB_NAME");
      string dbHost = Environment.GetEnvironmentVariable("DB_SERVER");

      if (string.IsNullOrEmpty(dbUser) || string.IsNullOrEmpty(dbPass) || string.IsNullOrEmpty(dbName) || string.IsNullOrEmpty(dbHost))
      {
        Messages.Error($"Одна из переменных окружения не загружена");
        return;
      }

      string connectionParams = $"Server={dbHost};Database={dbName};User ID={dbUser};Password={dbPass};";

      using (MySqlConnection connection = new MySqlConnection(connectionParams))
      {
        try
        {
          await connection.OpenAsync();
        }
        catch (MySqlException e)
        {
          Messages.Error($"{e.Message}");
        }
        catch (Exception e)
        {
          Messages.Error($"{e.Message}");
        }
      }
    }
    public MySqlConnect()
    {
      Connect();
    }
  }
}

