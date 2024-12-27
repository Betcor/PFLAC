using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLAC
{
  internal class MilitaryPerson
  {
    public string Name {  get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Status { get; set; }
    public List<int> Results { get; set; }
    private List<int> Scores;
    private List<string> Grades;

    public MilitaryPerson()
    {
      Results = new List<int>();
      Scores = new List<int>();
      Grades = new List<string>();
    }
    public MilitaryPerson(string name, int age)
    {
      Name = name;
      Age = age;
      Results = new List<int>();
      Scores = new List<int>();
      Grades = new List<string>();
    }
    public List<int> CalculateScore()
    {
      List<int> scores = new List<int>();
      return scores;
    }

  }
}
