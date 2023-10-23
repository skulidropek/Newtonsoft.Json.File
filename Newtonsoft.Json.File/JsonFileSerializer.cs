using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Newtonsoft.Json.File
{
    public class JsonFileSerializer
    {
        public static T ReadFileToJson<T>(string path)
        {
            return JsonConvert.DeserializeObject<T>(System.IO.File.ReadAllText(path));
        }
        
        public static void WriteFileToJson<T>(string path, T t)
        {
            System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(t));
        }
        
        public static async Task<T> ReadFileToJsonAsync<T>(string path)
        {
            return JsonConvert.DeserializeObject<T>(await System.IO.File.ReadAllTextAsync(path));
        }
        
        public static async Task WriteFileToJsonAsync<T>(string path, T t)
        {
            await System.IO.File.WriteAllTextAsync(path, JsonConvert.SerializeObject(t));
        }
    }
}