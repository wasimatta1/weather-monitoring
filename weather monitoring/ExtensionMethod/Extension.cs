
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace weather_monitoring.ExtensionMethod
{
    public static class Extension
    {

        public static T? DeserilizeFromJsonString<T>(this string input)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(input);
            }
            catch
            {
                return default(T);
            }
        }

        public static T DeserializeFromXmlString<T>(this string input)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));

                using (TextReader reader = new StringReader(input))
                {
                    return (T)xmlSerializer.Deserialize(reader);
                }
            }
            catch
            {
                return default(T);
            }

        }
        public static string ReadFile(this string path)
        {
            Type type = typeof(Program);
            var assembly = type.Assembly;

            var stream = assembly.GetManifestResourceStream(type, path);

            if (stream == null)
            {
                throw new Exception("File not found");
            }

            return new StreamReader(stream).ReadToEnd();
        }
    }
}
