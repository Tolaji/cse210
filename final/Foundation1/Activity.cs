using System;

public abstract class Activity
{
    private DateTime date;
    private int duration;

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date
    {
        get { return this.date; }
    }

    public int Duration
    {
        get { return this.duration; }
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{this.date.ToString("dd MMM yyyy")} {this.GetType().Name} ({this.duration} min): Distance {this.GetDistance():F1}, Speed {this.GetSpeed():F1}, Pace {this.GetPace():F2} min per unit";
    }
}
