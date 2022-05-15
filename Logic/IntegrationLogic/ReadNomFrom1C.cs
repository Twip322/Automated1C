using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITworks.Brom;
using ITworks.Brom.Types;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Logic.Models.HelperModels;

namespace Logic.IntegrationLogic
{
    public class ReadNomFrom1C
    {
        public ТаблицаЗначений Read(БромКлиент клиент)
        {
            Запрос запросНоменкулатуры = клиент.СоздатьЗапрос(@"
				ВЫБРАТЬ
					Номенклатура.Наименование КАК Наименование,
					Номенклатура.Артикул КАК Артикул
				ИЗ
					Справочник.Номенклатура КАК Номенклатура
				ГДЕ
					Номенклатура.ЭтоГруппа = ЛОЖЬ

				УПОРЯДОЧИТЬ ПО
					Наименование			
			");
            ТаблицаЗначений результат = (ТаблицаЗначений)запросНоменкулатуры.Выполнить();
            return результат;
        }
        public void CreateXLSX(ТаблицаЗначений результат, string filepath)
        {
            using (SpreadsheetDocument spreadsheetDocument =
            SpreadsheetDocument.Create(filepath+"Nom", SpreadsheetDocumentType.Workbook))
            {
                // Создаем книгу (в ней хранятся листы)
                WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
                workbookpart.Workbook = new Workbook();
                // Получаем/создаем хранилище текстов для книги
                SharedStringTablePart shareStringPart =
               spreadsheetDocument.WorkbookPart.GetPartsOfType<SharedStringTablePart>().Count() > 0
                ?
               spreadsheetDocument.WorkbookPart.GetPartsOfType<SharedStringTablePart>().First()
                :
               spreadsheetDocument.WorkbookPart.AddNewPart<SharedStringTablePart>();
                // Создаем SharedStringTable, если его нет
                if (shareStringPart.SharedStringTable == null)
                {
                    shareStringPart.SharedStringTable = new SharedStringTable();
                }
                // Создаем лист в книгу
                WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());
                // Добавляем лист в книгу
                Sheets sheets =
               spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());
                Sheet sheet = new Sheet()
                {
                    Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Лист"
                };
                sheets.Append(sheet);
                uint rowIndex = 1;
                foreach (dynamic стр in результат)
                {
                    InsertCellInWorksheet(new ExcelCellParameters
                    {
                        Worksheet = worksheetPart.Worksheet,
                        ShareStringPart = shareStringPart,
                        ColumnName = "A",
                        RowIndex = rowIndex,
                        Text = '='+'"'+стр.Наименование+'"',
                        StyleIndex = 1U
                    });
                    InsertCellInWorksheet(new ExcelCellParameters
                    {
                        Worksheet = worksheetPart.Worksheet,
                        ShareStringPart = shareStringPart,
                        ColumnName = "B",
                        RowIndex = rowIndex,
                        Text = '=' + '"'+стр.Артикул+'"',
                        StyleIndex = 1U
                    });
                    rowIndex++;
                }
                workbookpart.Workbook.Save();
            }
        }
        private static void InsertCellInWorksheet(ExcelCellParameters cellParameters)
        {
            SheetData sheetData = cellParameters.Worksheet.GetFirstChild<SheetData>();
            // Ищем строку, либо добавляем ее
            Row row;
            if (sheetData.Elements<Row>().Where(r => r.RowIndex ==
           cellParameters.RowIndex).Count() != 0)
            {
                row = sheetData.Elements<Row>().Where(r => r.RowIndex ==
cellParameters.RowIndex).First();
            }
            else
            {
                row = new Row() { RowIndex = cellParameters.RowIndex };
                sheetData.Append(row);
            }
            // Ищем нужную ячейку
            Cell cell;
            if (row.Elements<Cell>().Where(c => c.CellReference.Value ==
           cellParameters.CellReference).Count() > 0)
            {
                cell = row.Elements<Cell>().Where(c => c.CellReference.Value ==
               cellParameters.CellReference).First();
            }
            else
            {
                // Все ячейки должны быть последовательно друг за другом расположены
                // нужно определить, после какой вставлять
                Cell refCell = null;
                foreach (Cell rowCell in row.Elements<Cell>())
                {
                    if (string.Compare(rowCell.CellReference.Value,
                   cellParameters.CellReference, true) > 0)
                    {
                        refCell = rowCell;
                        break;
                    }
                }
                Cell newCell = new Cell()
                {
                    CellReference = cellParameters.CellReference
                };
                row.InsertBefore(newCell, refCell);
                cell = newCell;
            }
            // вставляем новый текст
            cellParameters.ShareStringPart.SharedStringTable.AppendChild(new
           SharedStringItem(new Text(cellParameters.Text)));
            cellParameters.ShareStringPart.SharedStringTable.Save();
            cell.CellValue = new
           CellValue((cellParameters.ShareStringPart.SharedStringTable.Elements<SharedStringItem>().
           Count() - 1).ToString());
            cell.DataType = new EnumValue<CellValues>(CellValues.SharedString);
            cell.StyleIndex = cellParameters.StyleIndex;
        }
    }
}
