using System.Text.Json;
using System.IO;
using Microsoft.Maui.Storage;



namespace ClassShedule.MVVM.Service
{
    internal class JsonReader<T>
    {
        public async Task<T> LoadAsync(string fileName)
        {
            using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(fileName); //stream from file, using using for idispose
            using StreamReader reader = new StreamReader(fileStream);

            var jsonContent = await reader.ReadToEndAsync();
            return JsonSerializer.Deserialize<T>(jsonContent);
        }
        
        
        
        
        
        /*public async Task<List<T>> LoadAsync(string _FilePath)
        {
            if (!File.Exists(_FilePath)) return new List<T>();
            using var file = File.OpenRead(_FilePath);
            return await JsonSerializer.DeserializeAsync<List<T>>(file)
                ?? new List<T>();
        }*/

    }
}
