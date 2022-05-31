using ITworks.Brom;
using ITworks.Brom.Types;
using Logic.DataModels;
using Logic.Models;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.IntegrationLogic
{
    public static class NeedTicketController
    {
        public static void ReadNeedTickets()
        {
            dynamic клиент = Client.bromClient;
            Запрос запрос = клиент.СоздатьЗапрос(@"
                   ВЫБРАТЬ
	                        ТребованиеНакладная.Дата КАК Дата,
	                        ТребованиеНакладная.Номер КАК Номер
                        ИЗ
	                        Документ.ТребованиеНакладная КАК ТребованиеНакладная

                        СГРУППИРОВАТЬ ПО
	                        ТребованиеНакладная.Дата,
	                        ТребованиеНакладная.Номер");
            ТаблицаЗначений result = (ТаблицаЗначений)запрос.Выполнить();
            Serialization(result, FileSettings.NeedsFilePath);
        }
        public static void Serialization(ТаблицаЗначений result, string fileName)
        {
            List <DocumentModel> list = new List<DocumentModel>();
            foreach (dynamic res in result)
            {
                list.Add(new DocumentModel { Date = res.Дата, Code = res.Номер });
            }
            TextWriter writer = new StreamWriter(fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DocumentModel>));
            xmlSerializer.Serialize(writer, list);
            writer.Close();
        }
        public static List<NeedTicketDataModel> LoadNeedTicket(DocumentModel model)
        {
            dynamic клиент = Client.bromClient;
            dynamic докСсылка = клиент.Документы.ТребованиеНакладная.НайтиПоНомеру(model.Code,model.Date);
            dynamic докОбъект = докСсылка.ПолучитьОбъект();
            List<NeedTicketDataModel> list = new List<NeedTicketDataModel>();
            foreach (var test in докОбъект.Материалы)
            {
                list.Add(new NeedTicketDataModel { Name=test.Номенклатура.ToString(), Count = int.Parse(test.Количество.ToString())});
            }
            return list;
        }
        public static void UpdateDataNeedTicket(DocumentModel ticketModel, Dictionary<string, int> dict)
        {
            dynamic клиент = Client.bromClient;
            dynamic докСсылка = клиент.Документы.ТребованиеНакладная.НайтиПоНомеру(ticketModel.Code, ticketModel.Date);
            dynamic докОбъект = докСсылка.ПолучитьОбъект();
            докОбъект.Материалы.Очистить();
            foreach (var model in dict)
            {
                dynamic стр = докОбъект.Материалы.Добавить();
                стр.Номенклатура = клиент.Справочники.Номенклатура.НайтиПоНаименованию(model.Key);
                стр.Количество = model.Value;
            }
            докОбъект.Записать();
        }
        public static void DeleteNeedTicket(DocumentModel model)
        {
            dynamic клиент = Client.bromClient;
            dynamic докСсылка = клиент.Документы.ТребованиеНакладная.НайтиПоНомеру(model.Code, model.Date);
            dynamic докОбъект = докСсылка.ПолучитьОбъект();
            докОбъект.Удалить();
        }
        public static void CreateTicket(Dictionary<string,int> dict)
        {
            dynamic клиент = Client.bromClient;
            dynamic докОбъект = клиент.Документы.ТребованиеНакладная.СоздатьДокумент();
            foreach (var model in dict)
            {
                dynamic стр = докОбъект.Материалы.Добавить();
                стр.Номенклатура = клиент.Справочники.Номенклатура.НайтиПоНаименованию(model.Key);
                стр.Количество = model.Value;
            }
            докОбъект.Записать();    
        }
    }
}
