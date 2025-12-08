using ClassShedule.MVVM.Model;

namespace ClassShedule.MVVM.Service;

internal static class MakeSubjectsList
{
    public static List<Subject> GetSubjectsList(List<string> subjectsStrings)
    {
        var subjectsList = new List<Subject>();

        #region time Consts init
        var startTime = new DateTime(2025, 1,1,8,0,0);
        const int interval = 40;
        var bellsInterval = GetBellsInterval();
        #endregion

        for(var i = 0; i < subjectsStrings.Count; i++)
        {
            var endSpan = new TimeSpan(0,interval,0);     
            var endTime = startTime + endSpan;
            
            
            subjectsList.Add(new Subject(subjectsStrings[i], startTime, endTime));


            var nextSpan = new TimeSpan(0, interval + bellsInterval[i], 0);
            startTime += nextSpan;
        }

        return subjectsList;
    }

    

    private static int[] GetBellsInterval() => new[] { 5, 10, 5, 10, 5, 5 , 5, 5 };
}
