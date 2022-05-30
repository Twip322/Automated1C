using Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.FileLogic
{
    public static class NomenclatureFileController
    {
        public static List<NomenclatureModel> Read(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomenclatureModel>));
            TextReader reader = new StreamReader(fileName);
            List<NomenclatureModel> list = (List<NomenclatureModel>)xmlSerializer.Deserialize(reader);
            reader.Close();
            return list;
        }
        public static void Write(List<NomenclatureModel> list, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomenclatureModel>));
            TextWriter writer = new StreamWriter(fileName) { AutoFlush = true };
            xmlSerializer.Serialize(writer, list);
            writer.Close();
        }
    }
}
