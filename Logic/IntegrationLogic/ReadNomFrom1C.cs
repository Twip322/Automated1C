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
using System.Xml.Serialization;
using Logic.Models;
using System.IO;

namespace Logic.IntegrationLogic
{
    public class ReadNomFrom1C
    {
        public ТаблицаЗначений Read(БромКлиент клиент, string fileName)
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
            CreateSerializedContent(результат, fileName);
            return результат;
        }
        public void CreateSerializedContent(ТаблицаЗначений результат, string fileName)
        {
            List<Models.NomModel> list = new List<Models.NomModel>();
            foreach (dynamic ctp in результат)
            {
                list.Add(new NomModel { Name = ctp.Наименование, Article = ctp.Артикул });
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomModel>));
            using (TextWriter textWr = new StreamWriter(fileName))
            {
                xmlSerializer.Serialize(textWr, list);
                textWr.Flush();
                textWr.Close();
            }
        }
    }
}
