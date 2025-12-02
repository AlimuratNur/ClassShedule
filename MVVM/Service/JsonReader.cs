using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
