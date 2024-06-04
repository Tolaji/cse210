public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (this.speed * this.Duration) / 60;
    }

    public override double GetSpeed()
    {
        return this.speed;
    }

    public override double GetPace()
    {
        return 60 / this.speed;
    }
}
