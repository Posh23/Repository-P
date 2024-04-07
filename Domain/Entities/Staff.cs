namespace ConsoleApp1.Entities;

public class Staff
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Position { get; set; }

    public Studio Studio { get; set; }
}