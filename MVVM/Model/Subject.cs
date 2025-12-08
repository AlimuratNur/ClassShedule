

namespace ClassShedule.MVVM.Model;

internal class Subject
{
    public string Name { get; }
    public DateTime Start { get; }
    public DateTime End { get; }

    public Subject(string name, DateTime start, DateTime end)
    {
        Name = name;
        Start = start;
        End = end;

    }
}
