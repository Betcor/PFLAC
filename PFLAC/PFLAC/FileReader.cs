using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace PFLAC
{
  internal class FileReader
  {
    public List<MilitaryPerson> ReadFromExcel(string filePath)
    {
      ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
      // Проверка существования файла
      if (!File.Exists(filePath))
      {
        throw new FileNotFoundException("Файл не найден!", filePath);
      }

      var militaryPersons = new List<MilitaryPerson>();

      // Используем библиотеку EPPlus
      using (var package = new ExcelPackage(new FileInfo(filePath)))
      {
        var worksheet = package.Workbook.Worksheets[0]; // Берем первый лист

        int row = 2; // Предполагаем, что первая строка — это заголовки
        while (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Text))
        {
          string fullName = worksheet.Cells[row, 1].Text;
          int age = int.Parse(worksheet.Cells[row, 2].Text);

          militaryPersons.Add(new MilitaryPerson(fullName, age));
          row++;
        }
      }

      return militaryPersons;
    }
  }
}
