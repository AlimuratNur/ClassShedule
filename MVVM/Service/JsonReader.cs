using System.Text.Json;

namespace ClassShedule.MVVM.Service;

internal class JsonReader<T>
{
    public async Task<T> LoadAsync(string fileName)
    {
        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(fileName); //stream from file, using using for idispose
        using StreamReader reader = new StreamReader(fileStream);

        var jsonContent = await reader.ReadToEndAsync();
        return JsonSerializer.Deserialize<T>(jsonContent);
    }
}
