using ClassShedule.MVVM.ViewModels.Base;
using ClassShedule.MVVM.Service;


namespace ClassShedule.MVVM.ViewModels;

internal class MainViewModel : ViewModel
{
    private List<string>? _today;
    public List<string> TodaysDaySub { get => _today; set => Set(ref _today, value); }

    private string test;
    public string Test { get => test; set => Set(ref test, value); }
    public MainViewModel()
    {
        _init();
    }

    private async void _init()
    {

        
        var jsonReader = new JsonReader<List<List<string>>>();
        var allDaySubjects =  await jsonReader.LoadAsync("Subjects.json");
        
        if (!allDaySubjects.Any()) return;

        TodaysDaySub = GetDay.GetSubjects(allDaySubjects);



    }

    



}
