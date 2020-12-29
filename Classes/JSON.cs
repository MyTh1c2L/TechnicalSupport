using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace TechnicalSupport
{
    class WorkWithFileJson
    {
        public object GetJSONDataWithFile(string JsonSettingFilePath, Type JsonDeserializeType)
        {
            object Obj = new object();
            if (new FileInfo(JsonSettingFilePath).Exists)
            {
                using (StreamReader sr = new StreamReader(JsonSettingFilePath))
                {
                    string jsonFileText = sr.ReadToEnd();

                    Obj = JsonConvert.DeserializeObject(jsonFileText, JsonDeserializeType);
                }
            }
            else
            {
                return "Нет файла";
            }
            return Obj;
        }
    }

    class OpenFileJson
    {
        public void NewFile()
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                var json = System.IO.File.ReadAllText(filePath);
                System.IO.File.WriteAllText("JSONFile/DataBase.json", json);
            }
        }
    }
}
