using ITworks.Brom;
using Logic.Models;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.IntegrationLogic
{
    public static class NeedTicketController
    {
        public static void CreateTicket(Dictionary<NomenclatureModel,int> dict)
        {
            dynamic клиент = Client.bromClient;
            dynamic докОбъект = клиент.Документы.ТребованиеНакладная.СоздатьЭлемент();
            foreach (var model in dict)
            {
                dynamic стр = докОбъект.Товары.Добавить();
                стр.Номенклатура = клиент.Спрвочники.Номенклатура.НайтиПоНаименованию(model.Key);
                стр.Количество = model.Value;
            }
            докОбъект.Записать();    
        }
    }
}
