using Logic.IntegrationLogic;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.HelperModels
{
    public static class LoadController
    {
        public static void LoadNomenclature()
        {
            Nomenclature1CController.Read(Client.bromClient, FileSettings.NomenclatureFilePath);
        }
    }
}
