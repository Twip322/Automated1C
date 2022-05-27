using Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.FileLogic
{
    public class LastsFileController
    {
        public List<LastsModel> Read(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomenclatureModel>));
            TextReader reader = new StreamReader(fileName);
            List<LastsModel> list = (List<LastsModel>)xmlSerializer.Deserialize(reader);
            reader.Close();
            return list;
        }
    }
}
