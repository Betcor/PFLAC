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

// form onload
/*

if (IsEthernetAvailable()) {
   Message.Success("Підключення до Інтернету");
} else {
   Message.Error("Нема Інтернету!");
}

*/

    private void loadFileBtn_Click(object sender, EventArgs e)
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
    private void DisplayPerson(MilitaryPerson person)
    {
      fullNameTxtBox.Text = person.Name;
      ageTxtBox.Text = person.Age.ToString();
      if (person.Gender == "Male")
      {
        maleRdBtn.Checked = true;
      }
      else if (person.Gender == "Female")
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
      person.Gender = maleRdBtn.Checked ? "Male" : femaleRdBtn.Checked ? "Female" : "";
      person.Status = oficerRdBtn.Checked ? "Officer" : soldierRdBtn.Checked ? "Contract" : "";
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
      if (currentIndex < persons.Count - 1)
      {
        SavePersonData(persons[currentIndex]);
        currentIndex++;
        DisplayPerson(persons[currentIndex]);
      }
    }

    private void previousBtn_Click(object sender, EventArgs e)
    {
      if (currentIndex > 0)
      {
        SavePersonData(persons[currentIndex]);
        currentIndex--;
        DisplayPerson(persons[currentIndex]);
      }
    }
  }
}
