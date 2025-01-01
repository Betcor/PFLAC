using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PFLAC
{
  class MySqlConnect : IDisposable
  {
    /*
    * @private
    */
    private MySqlConnection _connection;
    
    /*
    * @public
    */
    public MySqlConnect()
    {
      Connect().Wait();
    }
    
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
      _connection = new MySqlConnection(connectionParams);

      try
      {
        await _connection.OpenAsync();
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

    /*
    * @public
    */
    public MySqlCommand CreateCommand(string query)
    {
      return new MySqlCommand(query, _connection);
    }

    /*
    * @public
    */
    public void Dispose()
    {
      _connection?.Dispose();
    }
  }
}

