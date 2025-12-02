
namespace ClassShedule.MVVM.Service
{
    internal static class GetDay
    {
        public static List<string> GetSubjects(List<List<string>> allDays)
        {
            var dateNow = DateTime.Now.DayOfWeek;
            List<string> result;
            switch (dateNow)
            {
                case DayOfWeek.Monday:
                    result = allDays[0];
                    break;
                case DayOfWeek.Tuesday:
                    result = allDays[1];
                    break;
                case DayOfWeek.Wednesday:
                    result = allDays[2];
                    break;
                case DayOfWeek.Thursday:
                    result = allDays[3];
                    break;
                case DayOfWeek.Friday:
                    result = allDays[4];
                    break;
                default:
                    result = new List<string>();
                    break;
            }

            return result;
        }
    }
}
