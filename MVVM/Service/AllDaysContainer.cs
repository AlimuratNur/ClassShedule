

namespace ClassShedule.MVVM.Service;

internal static class AllDaysContainer
{
    public static List<List<string>> GetAllDay()
    {
        var res = new List<List<string>>();

        res.Add(new List<string>() {"география",
                                     "алгебра",
                                     "каз.тарих",
                                     "орыс тілі",
                                     "химия",
                                     "биология",
                                     "сынып сағаты" });


         res.Add(new List<string>() {"геометрия",
                    "физика",
                    "шет тілі",
                     "дене",
                     "АӨД",
                     "қазақ әдебиеті",
                     "химия" 
         });

        res.Add( new List<string>()
        {
            "д.ж.тарихы",
            "информатика",
            "шет тілі",
            "физика",
            "алгебра",
            "қазақ тілі"
        });

        res.Add( new List<string>() { "каз.тарихы",
                "геометрия",
                "биология",
                    "дене",
                "география",
                "құқық",
                "шет тілі"});

        res.Add ( new List<string>()
        {
            "алгебра",
            "дене",
            "орыс тілі",
            "информатика",
            "алгебра",
            "қазақ әдебиеті"
        });
        return res;
    }
}
