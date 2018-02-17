using System;
public class WeeklyEntry:IComparable<WeeklyEntry>
{
    private WeekDay weekday;
    public string Notes { get; private set; }
    public WeekDay Weekday => this.weekday;
    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.weekday);
        this.Notes = notes;
    }

    public override string ToString()
    {
        return $"{this.Weekday} - {this.Notes}";
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var weekdayComparison = weekday.CompareTo(other.weekday);
        if (weekdayComparison != 0) return weekdayComparison;
        return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
    }
}



