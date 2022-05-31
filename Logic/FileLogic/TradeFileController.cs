using Logic.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.FileLogic
{
    public class TradeFileController
    {
        public static List<DocumentModel> Read(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DocumentModel>));
            TextReader reader = new StreamReader(fileName);
            List<DocumentModel> list = (List<DocumentModel>)xmlSerializer.Deserialize(reader);
            reader.Close();
            return list;
        }
        public static void Write(List<DocumentModel> list, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DocumentModel>));
            TextWriter writer = new StreamWriter(fileName) { AutoFlush = true };
            xmlSerializer.Serialize(writer, list);
            writer.Close();
        }
    }
}
