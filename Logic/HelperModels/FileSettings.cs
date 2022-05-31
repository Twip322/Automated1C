using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Logic.Settings
{
    public static class FileSettings
    {
        private readonly static string sFilePath = Directory.GetCurrentDirectory() + "settings.conf";
        public static string SettingsFilePath { get { return sFilePath; } }
        public static string NomenclatureFilePath { get; private set; }
        public static string LastsFilePath { get; private set; }
        public static string NeedsFilePath { get; private set; }
        public static string TradesFilePath { get; private set; }
        public static string OperationsFilePath { get; private set; }
        public static void LoadSettings()
        {
            TextReader reader = new StreamReader(sFilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<FileSettingModel>));
            List<FileSettingModel> list = (List<FileSettingModel>)serializer.Deserialize(reader);
            foreach(FileSettingModel setting in list)
            {
                switch(setting.SettingName)
                {
                    case "nomenclature":
                        NomenclatureFilePath = setting.FilePath;
                        break;
                    case "lasts":
                        LastsFilePath = setting.FilePath;
                        break;
                    case "needs":
                        NeedsFilePath = setting.FilePath;
                        break;
                    case "operations":
                        OperationsFilePath = setting.FilePath;
                        break;
                    case "trades":
                        TradesFilePath = setting.FilePath;
                        break;
                }
            }
        }
        public static void ChangeSettings(List<FileSettingModel> settings)
        {
            TextWriter writer = new StreamWriter(sFilePath) { AutoFlush = true};
            XmlSerializer serializer = new XmlSerializer(typeof(List<FileSettingModel>));
            serializer.Serialize(writer,settings);
            writer.Close();
        }
        public static void returnToDefaultSettings()
        {
            List<FileSettingModel> defaultSettings = new List<FileSettingModel>();
            defaultSettings.Add(new FileSettingModel { SettingName = "nomenclature", FilePath = Directory.GetCurrentDirectory()+ "nomenclature.txt" });
            defaultSettings.Add(new FileSettingModel { SettingName = "lasts", FilePath = Directory.GetCurrentDirectory()+ "operations.txt" });
            defaultSettings.Add(new FileSettingModel { SettingName = "needs", FilePath = Directory.GetCurrentDirectory() + "needs.txt" });
            defaultSettings.Add(new FileSettingModel { SettingName = "trades", FilePath = Directory.GetCurrentDirectory() + "trades.txt" });
            defaultSettings.Add(new FileSettingModel { SettingName = "operations", FilePath = Directory.GetCurrentDirectory() + "operations.txt" });

            ChangeSettings(defaultSettings);
        }
    }
    public class FileSettingModel
    {
        public string SettingName { get; set; }
        public string FilePath { get; set; }
    }
}
