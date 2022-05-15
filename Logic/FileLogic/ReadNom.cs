using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.FileLogic
{
    public class ReadNom
    {
        public static List<NomModel> ReadDoc(string fileName)
        {
            fileName = fileName + "Nom.xlsx";
            List<NomModel> list = new List<NomModel>();
            using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Open(fileName, true))
            {
                WorkbookPart workbookPart = spreadsheet.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
                string text = null;
                foreach (Row r in sheetData.Elements<Row>())
                {
                    foreach (Cell c in r.Elements<Cell>())
                    {
                        text += c.CellValue.Text;
                        text += " ";
                    }
                    string[] texting = text.Split(' ');
                    list.Add(new NomModel { Name = texting[0].ToString(), Article = texting[1].ToString()});
                    text = null;
                }
            }
            return list;
        }
    }
}
