using ITworks.Brom;
using ITworks.Brom.Types;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.IntegrationLogic
{
    public class ReadNomenclatureFrom1C
    {
        public void Read(БромКлиент client, string fileName)
        {
			Запрос request = client.СоздатьЗапрос(@"
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
			ТаблицаЗначений result = (ТаблицаЗначений)request.Выполнить();
			Serialization(result, fileName);
        }
		public void Serialization(ТаблицаЗначений result,string fileName)
        {
			List<NomenclatureModel> list = new List<NomenclatureModel>();
			foreach(dynamic res in result)
            {
				list.Add(new NomenclatureModel { Name = res.Наименование, Article = res.Артикул });
            }
			TextWriter writer = new StreamWriter(fileName);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomenclatureModel>));
			xmlSerializer.Serialize(writer,list);
			writer.Close();
        }
    }
}
