using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLAC
{
  static class DataBaseHandler
  {
    public static Dictionary<int, string> FetchNorms(int age, string gender)
    {
      if (age <= 0 || string.IsNullOrWhiteSpace(gender))
      {
        throw new ArgumentException("Некорректные входные данные.");
      }

      Dictionary<int, string> norms = new Dictionary<int, string>();
      string query = @"SELECT exercise_number, exercise_name FROM table_physical WHERE age = @Age AND gender = @Gender;";

      try
      {
        using (MySqlConnect connection = new MySqlConnect())
        {
          using (MySqlCommand command = new MySqlCommand(query))
          {
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Gender", gender);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                if (int.TryParse(reader["NormValue"].ToString(), out int key))
                {
                  string value = reader["NormKey"].ToString();
                  norms[key] = value;
                }
              }
            }
          } 
        }
      }
      catch (Exception ex)
      {
        Messages.Error("Ошибка при работе с базой данных: " + ex.Message);
      }

      return norms;
    }
  }
}
