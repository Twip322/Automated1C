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
            dynamic клиент = Client.bromClient;
            foreach (var data in operationsList)
            {
                switch (data.DataType)
                {
                    case DataTypeEnum.Номенклатура:
                        switch (data.Operation)
                        {
                            case OperationEnum.Добавление:
                                Nomenclature1CController.CreateNomenclature((NomenclatureModel)data.Data);
                                break;
                            case OperationEnum.Изменение:
                                Nomenclature1CController.UpdateNomenclature((NomenclatureModel)data.oldData, (NomenclatureModel)data.Data);
                                break;
                            case OperationEnum.Удаление:
                                Nomenclature1CController.DeleteNomenclature((NomenclatureModel)data.Data);
                                break;
                        }
                        break;
                    case DataTypeEnum.Требование:
                        switch(data.Operation)
                        {
                            case OperationEnum.Добавление:
                                Dictionary<NomenclatureModel, int> test = new Dictionary<NomenclatureModel, int>();
                                foreach(var dat in data.Data)
                                {
                                    test.Add(dat.model, dat.count);
                                }
                                NeedTicketController.CreateTicket(test);
                                break;
                        }
                        break;
                }
            }
            operationsList.Clear();
        }
    }
    

}
