using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSFW.GridDesignerCommon
{
    internal static class Ux
    {
        public static void SaveFile<T>(T obj, string filePath, Encoding encoding = null)
        {
            if (obj == null) return;

            if (string.IsNullOrWhiteSpace(filePath)) return;

            string dir = Path.GetDirectoryName(filePath);
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

            File.WriteAllText(filePath, json, encoding ?? Encoding.UTF8);
        }

        public static T LoadFile<T>(string filePath, Encoding encoding = null)
        {
            T obj = default(T);

            if (File.Exists(filePath) == false)
            {
                return obj;
            }

            try
            {
                string json = File.ReadAllText(filePath, encoding ?? Encoding.UTF8);
                obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                obj = default(T);
            }
            return obj;
        }
    }

}
