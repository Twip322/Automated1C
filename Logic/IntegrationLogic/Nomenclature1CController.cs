using ITworks.Brom;
using ITworks.Brom.Types;
using Logic.Models;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic.IntegrationLogic
{
    public static class Nomenclature1CController
    {
		public static void Read(БромКлиент client, string fileName)
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
		public static void Serialization(ТаблицаЗначений result,string fileName)
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
		public static void CreateNomenclature(NomenclatureModel model)
        {
			dynamic клиент = Client.bromClient;
			dynamic докОбъект = клиент.Справочники.Номенклатура.СоздатьЭлемент();
			докОбъект.Наименование = model.Name;
			докОбъект.Артикул = model.Article;
			докОбъект.Записать();
        }
		public static void UpdateNomenclature(NomenclatureModel oldModel, NomenclatureModel newModel)
		{
			dynamic клиент = Client.bromClient;
			dynamic ссылка = клиент.Справочники.Номенклатура.НайтиПоНаименованию(oldModel.Name);
			dynamic объект = ссылка.ПолучитьОбъект();
			объект.Наименование = newModel.Name;
			объект.Артикул = newModel.Article;
			объект.Записать();
		}
		public static void DeleteNomenclature(NomenclatureModel Model)
		{
			dynamic клиент = Client.bromClient;
			dynamic ссылка = клиент.Справочники.Номенклатура.НайтиПоНаименованию(Model.Name);
			dynamic объект = ссылка.ПолучитьОбъект();
			объект.Удалить();
			
		}
	}
}
