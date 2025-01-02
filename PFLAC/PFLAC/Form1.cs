using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using DotNetEnv;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Protobuf.Compiler;
using StackExchange.Redis;

namespace PFLAC
{
    public partial class Form1 : Form
    {
    private List<MilitaryPerson> persons = new List<MilitaryPerson>();
    private FileReader fileReader = new FileReader();
    private OutputHandler outputHandler = new OutputHandler();

    private int currentIndex = 0;

    public Form1()
    {
      InitializeComponent();
    }
        
    private void Form1_Load(object sender, EventArgs e)
    {
      string fullPath = Env.GetFullPath(GetStatus());
      DotNetEnv.Env.Load(fullPath);

      string lastUpdated = GetLastChangeDate();
      string _updateLocal = db.HashGet(key, "last_updated");
      
      if (lastUpdated == _updateLocal)
      {
          // connect to db with error))
          // MySqlConnect conn = new MySqlConnect();
          
          Messages.Error("1");

          GetUpdateDatabase();
      }

      if (!EthernetCheck.IsEthernetAvailable())
      {
        // TODO DOCKER REDIS ;)
      }
    }

    public static string GetStatus()
    {
      string envStatus = Environment.GetEnvironmentVariable("STATUS");
      string status = envStatus == "dev" ? "dev" :
              envStatus == "test" ? "test" : "prod";

      string fullPath = Env.GetFullPath(status);
      return status;
    }

    private void LoadFileBtn_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          persons = fileReader.ReadFromExcel(openFileDialog.FileName);
          if (persons.Count > 0)
          {
            currentIndex = 0;
            DisplayPerson(persons[currentIndex]);
          }
        }


      }
    }

    public string GetUpdateDataBase() {
       // todo
       string connectionString = "Server=localhost;Database=mydatabase;User ID=myuser;Password=mypassword;";

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT date FROM last_change LIMIT 1";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                var result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
        }
    }
    
    private void DisplayPerson(MilitaryPerson person)
    {
      fullNameTxtBox.Text = person.Name;
      ageTxtBox.Text = person.Age.ToString();
      if (person.Gender == "man")
      {
        maleRdBtn.Checked = true;
      }
      else if (person.Gender == "woman")
      {
        femaleRdBtn.Checked = true;
      }

      if (person.Status == "Officer")
      {
        oficerRdBtn.Checked = true;
      }
      else if (person.Status == "Contract")
      {
        soldierRdBtn.Checked = true;
      }
    }

    private void SavePersonData(MilitaryPerson person)
    {
      person.Name = fullNameTxtBox.Text;
      person.Age = int.Parse(ageTxtBox.Text);
      person.Gender = maleRdBtn.Checked ? "man" : femaleRdBtn.Checked ? "woman" : "";
      person.Status = oficerRdBtn.Checked ? "Officer" : soldierRdBtn.Checked ? "Contract" : "";
    }

    private void NextBtn_Click(object sender, EventArgs e)
    {
      if (currentIndex < persons.Count - 1)
      {
        SavePersonData(persons[currentIndex]);
        currentIndex++;
        DisplayPerson(persons[currentIndex]);
      }
    }

    private void PreviousBtn_Click(object sender, EventArgs e)
    {
      if (currentIndex > 0)
      {
        SavePersonData(persons[currentIndex]);
        currentIndex--;
        DisplayPerson(persons[currentIndex]);
      }
    }

    private void getNormsBtn_Click(object sender, EventArgs e)
    {
      SavePersonData(persons[currentIndex]);

      try
      {
        Dictionary<int, string> norms = DataBaseHandler.FetchNorms(persons[currentIndex].Age, persons[currentIndex].Gender);

        // Запись первых трех норм в соответствующие лейблы
        var normList = new List<string>(norms.Values);

        norm1Lbl.Text = normList.Count > 0 ? normList[0] : "Нет данных";
        norm2Lbl.Text = normList.Count > 1 ? normList[1] : "Нет данных";
        norm3Lbl.Text = normList.Count > 2 ? normList[2] : "Нет данных";

        norm1Lbl.Visible = true;
        norm2Lbl.Visible = true;
        norm3Lbl.Visible = true;
      }
      catch (Exception ex)
      {
        Messages.Error("Ошибка: " + ex.Message);
      }
    }
  }
}
