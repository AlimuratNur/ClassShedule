using System.Text.Json;


namespace ClassShedule.MVVM.Service
{
    internal class JsonReader<T>
    {
        public async Task<List<T>> LoadAsync(string _FilePath)
        {
            if (!File.Exists(_FilePath)) return new List<T>();
            using var file = File.OpenRead(_FilePath);
            return await JsonSerializer.DeserializeAsync<List<T>>(file)
                ?? new List<T>();
        }

    }
}
