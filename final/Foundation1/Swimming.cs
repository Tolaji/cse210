public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return this.laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (this.GetDistance() / this.Duration) * 60;
    }

    public override double GetPace()
    {
        return this.Duration / this.GetDistance();
    }
}
