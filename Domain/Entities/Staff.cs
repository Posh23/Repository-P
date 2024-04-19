namespace ConsoleApp1.Entities;

public class Staff : BaseEntity
{

    public string Name { get; set; }

    public string Position { get; set; }

    public Studio Studio { get; set; }
}