namespace ConsoleApp1.Entities;

public class Studio
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public Equipment Equipment { get; set; }
}