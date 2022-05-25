using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic.FileLogic
{
    public class NomChangeController
    {
        public void CreateOrUpdateNomFile(string fileName, List<NomModel> list)
        {
            using (TextWriter textWr = new StreamWriter(fileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomModel>));
                xmlSerializer.Serialize(textWr,list);
                textWr.Flush();
                textWr.Close();
            }
        }
        public List<NomModel> ReadFromNomFile(string fileName)
        {
            using (TextReader textRd = new StreamReader(fileName))
            {
                List<NomModel> list = new List<NomModel>();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NomModel>));
                list = (List<NomModel>)xmlSerializer.Deserialize(textRd);
                textRd.Close();
                return list;
            }
        }
    }
}
