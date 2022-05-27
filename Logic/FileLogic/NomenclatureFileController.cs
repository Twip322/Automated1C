using Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.FileLogic
{
    public class NomenclatureFileController
    {
        public List<NomenclatureModel> Read(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomenclatureModel>));
            TextReader reader = new StreamReader(fileName);
            List<NomenclatureModel> list = (List<NomenclatureModel>)xmlSerializer.Deserialize(reader);
            reader.Close();
            return list;
        }
    }
}
