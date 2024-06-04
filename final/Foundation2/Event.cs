using System;

public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {this.title}\nDescription: {this.description}\nDate: {this.date.ToShortDateString()}\nTime: {this.time}\nAddress: {this.address}";
    }

    public virtual string GetFullDetails()
    {
        return this.GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{this.GetType().Name}: {this.title} on {this.date.ToShortDateString()}";
    }
}
