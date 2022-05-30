using Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.FileLogic
{
    public static class LastsFileController
    {
        public static List<LastsModel> Read(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomenclatureModel>));
            TextReader reader = new StreamReader(fileName);
            List<LastsModel> list = (List<LastsModel>)xmlSerializer.Deserialize(reader);
            reader.Close();
            return list;
        }
        public static void Write(List<LastsModel> list, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<LastsModel>));
            TextWriter writer = new StreamWriter(fileName) { AutoFlush = true };
            xmlSerializer.Serialize(writer, list);
            writer.Close();
        }
    }
}
