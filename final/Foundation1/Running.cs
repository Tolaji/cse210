public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return this.distance;
    }

    public override double GetSpeed()
    {
        return (this.distance / this.Duration) * 60;
    }

    public override double GetPace()
    {
        return this.Duration / this.distance;
    }
}
