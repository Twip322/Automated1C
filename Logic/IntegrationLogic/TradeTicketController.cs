using ITworks.Brom;
using ITworks.Brom.Types;
using Logic.DataModels;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.IntegrationLogic
{
    public static class TradeTicketController
    {

        public static void ReadTradeTickets()
        {
            dynamic клиент = Client.bromClient;
            Запрос запрос = клиент.СоздатьЗапрос(@"
               ВЫБРАТЬ
	                ОтчетОРозничныхПродажах.Дата КАК Дата,
	                ОтчетОРозничныхПродажах.Номер КАК Номер
                ИЗ
	                Документ.ОтчетОРозничныхПродажах КАК ОтчетОРозничныхПродажах

                УПОРЯДОЧИТЬ ПО
	                Дата,
	                Номер");
            ТаблицаЗначений result = (ТаблицаЗначений)запрос.Выполнить();
            Serialization(result, FileSettings.TradesFilePath);
        }
        public static void Serialization(ТаблицаЗначений result, string fileName)
        {
            List<DocumentModel> list = new List<DocumentModel>();
            foreach (dynamic res in result)
            {
                list.Add(new DocumentModel { Date = res.Дата, Code = res.Номер });
            }
            TextWriter writer = new StreamWriter(fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DocumentModel>));
            xmlSerializer.Serialize(writer, list);
            writer.Close();
        }
        public static List<TradeDataModel> LoadTradeTicket(DocumentModel model)
        {
            dynamic клиент = Client.bromClient;
            dynamic докСсылка = клиент.Документы.ОтчетОРозничныхПродажах.НайтиПоНомеру(model.Code, model.Date);
            dynamic докОбъект = докСсылка.ПолучитьОбъект();
            List<TradeDataModel> list = new List<TradeDataModel>();
            foreach (var test in докОбъект.Товары)
            {
                list.Add(new TradeDataModel
                {
                    Name = test.Номенклатура.ToString(),
                    Count = int.Parse(test.Количество.ToString()),
                    Price = int.Parse(test.Цена.ToString()) });
            }
            return list;
        }
        public static void UpdateDataTradeTicket(DocumentModel ticketModel, Dictionary<string, (int,int)> dict)
        {
            dynamic клиент = Client.bromClient;
            dynamic докСсылка = клиент.Документы.ОтчетОРозничныхПродажах.НайтиПоНомеру(ticketModel.Code, ticketModel.Date);
            dynamic докОбъект = докСсылка.ПолучитьОбъект();
            докОбъект.Товары.Очистить();
            foreach (var model in dict)
            {
                dynamic стр = докОбъект.Товары.Добавить();
                стр.Номенклатура = клиент.Справочники.Номенклатура.НайтиПоНаименованию(model.Key);
                стр.Количество = model.Value.Item1;
                стр.Цена = model.Value.Item2;
            }
            докОбъект.Записать();
        }
        public static void DeleteTradeTicket(DocumentModel model)
        {
            dynamic клиент = Client.bromClient;
            dynamic докСсылка = клиент.Документы.ОтчетОРозничныхПродажах.НайтиПоНомеру(model.Code, model.Date);
            dynamic докОбъект = докСсылка.ПолучитьОбъект();
            докОбъект.Удалить();
        }
        public static void CreateTradeTicket(Dictionary<string, (int, int)> dict)
        {
            dynamic клиент = Client.bromClient;
            dynamic докОбъект = клиент.Документы.ОтчетОРозничныхПродажах.СоздатьДокумент();
            foreach (var model in dict)
            {
                dynamic стр = докОбъект.Товары.Добавить();
                стр.Номенклатура = клиент.Справочники.Номенклатура.НайтиПоНаименованию(model.Key);
                стр.Количество = model.Value.Item1;
                стр.Цена = model.Value.Item2;
            }
            докОбъект.Записать();
        }

    }
}
