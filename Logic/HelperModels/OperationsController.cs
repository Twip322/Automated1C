using ITworks.Brom;
using Logic.DataModels;
using Logic.FileLogic;
using Logic.IntegrationLogic;
using Logic.Models;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic.HelperModels
{
    public static class OperationsController
    {
        public static List<OperationModel> operationsList= new List<OperationModel>();
        public static  void LoadAll()
        {
            foreach (var operation in operationsList)
            {
                switch (operation.DataType)
                {
                    case DataTypeEnum.Номенклатура:
                        switch (operation.Operation)
                        {
                            case OperationEnum.Добавление:
                                NomenclatureController.CreateNomenclature((NomenclatureModel)operation.Data);
                                operationsList.Remove(operation);
                                break;
                            case OperationEnum.Изменение:
                                NomenclatureController.UpdateNomenclature((NomenclatureModel)operation.oldData, (NomenclatureModel)operation.Data);
                                operationsList.Remove(operation);
                                break;
                            case OperationEnum.Удаление:
                                NomenclatureController.DeleteNomenclature((NomenclatureModel)operation.Data);
                                operationsList.Remove(operation);
                                break;
                        }
                        break;
                   case DataTypeEnum.Требование:
                        switch(operation.Operation)
                        {
                            case OperationEnum.Добавление:
                                Dictionary<string, int> test = new Dictionary<string, int>();
                                foreach(var data in operation.Data)
                                {
                                    test.Add(data.Name, data.Count);
                                }
                                NeedTicketController.CreateTicket(test);
                                operationsList.Remove(operation);
                                break;
                            case OperationEnum.Изменение:
                                Dictionary<string, int> dict1 = new Dictionary<string, int>();
                                foreach (var data in operation.Data)
                                {
                                    dict1.Add(data.Name, data.Count);
                                }
                                NeedTicketController.UpdateDataNeedTicket(operation.oldData, dict1);
                                operationsList.Remove(operation);
                                break;
                            case OperationEnum.Удаление:
                                NeedTicketController.DeleteNeedTicket(operation.Data);
                                operationsList.Remove(operation);
                                break;
                        }
                        break;
                    case DataTypeEnum.Продажа:
                        switch (operation.Operation)
                        {
                            case OperationEnum.Добавление:
                                Dictionary<string, (int, int)> dict = new Dictionary<string, (int, int)>();
                                foreach (var data in operation.Data)
                                {
                                    var tuple = ValueTuple.Create(data.Count, data.Price);
                                    dict.Add(data.Name, tuple);
                                }
                                TradeTicketController.CreateTradeTicket(dict);
                                operationsList.Remove(operation);
                                break;
                            case OperationEnum.Изменение:
                                Dictionary<string, (int, int)> dict1 = new Dictionary<string, (int, int)>();
                                foreach (var data in operation.Data)
                                {
                                    var tuple = ValueTuple.Create(data.Count, data.Price);
                                    dict1.Add(data.Name, tuple);
                                }
                                TradeTicketController.UpdateDataTradeTicket(operation.oldData, dict1);
                                operationsList.Remove(operation);
                                break;
                            case OperationEnum.Удаление:
                                TradeTicketController.DeleteTradeTicket(operation.Data);
                                operationsList.Remove(operation);
                                break;
                        }
                        break;
                }
            }
            operationsList.Clear();
        }
        public static void LoadNomenclature()
        {
            foreach(var operation in operationsList)
            {
                if(operation.DataType == DataTypeEnum.Номенклатура)
                {
                    switch (operation.Operation)
                    {
                        case OperationEnum.Добавление:
                            NomenclatureController.CreateNomenclature((NomenclatureModel)operation.Data);
                            operationsList.Remove(operation);
                            break;
                        case OperationEnum.Изменение:
                            NomenclatureController.UpdateNomenclature((NomenclatureModel)operation.oldData, (NomenclatureModel)operation.Data);
                            operationsList.Remove(operation);
                            break;
                        case OperationEnum.Удаление:
                            NomenclatureController.DeleteNomenclature((NomenclatureModel)operation.Data);
                            operationsList.Remove(operation);
                            break;
                    }
                }
            }
        }
        public static void LoadNeedTicket()
        {
            foreach(var operation in operationsList)
            {
                if(operation.DataType == DataTypeEnum.Требование)
                {
                    switch(operation.Operation)
                    {
                        case OperationEnum.Добавление:
                            Dictionary<string, int> dict = new Dictionary<string, int>();
                            foreach (var data in operation.Data)
                            {
                                dict.Add(data.Name, data.Count);
                            }
                            NeedTicketController.CreateTicket(dict);
                            operationsList.Remove(operation);
                            break;
                        case OperationEnum.Изменение:
                            Dictionary<string, int> dict1 = new Dictionary<string, int>();
                            foreach (var data in operation.Data)
                            {
                                dict1.Add(data.Name, data.Count);
                            }
                            NeedTicketController.UpdateDataNeedTicket(operation.oldData,dict1);
                            operationsList.Remove(operation);
                            break;
                        case OperationEnum.Удаление:
                            NeedTicketController.DeleteNeedTicket(operation.Data);
                            operationsList.Remove(operation);
                            break;
                    }
                    
                }
            }
        }
        public static void LoadTradeTicket()
        {
            foreach(var operation in operationsList)
            {
                if(operation.DataType==DataTypeEnum.Продажа)
                {
                    switch (operation.Operation)
                    {
                        case OperationEnum.Добавление:
                            Dictionary<string, (int,int)> dict = new Dictionary<string, (int,int)>();
                            foreach (var data in operation.Data)
                            {
                                var tuple = ValueTuple.Create(data.Count, data.Price);
                                dict.Add(data.Name, tuple);
                            }
                            TradeTicketController.CreateTradeTicket(dict);
                            operationsList.Remove(operation);
                            break;
                        case OperationEnum.Изменение:
                            Dictionary<string, (int,int)> dict1 = new Dictionary<string, (int,int)>();
                            foreach (var data in operation.Data)
                            {
                                var tuple = ValueTuple.Create(data.Count, data.Price);
                                dict1.Add(data.Name, tuple);
                            }
                            TradeTicketController.UpdateDataTradeTicket(operation.oldData, dict1);
                            operationsList.Remove(operation);
                            break;
                        case OperationEnum.Удаление:
                            TradeTicketController.DeleteTradeTicket(operation.Data);
                            operationsList.Remove(operation);
                            break;
                    }
                }
            }
        }
    }
    

}
