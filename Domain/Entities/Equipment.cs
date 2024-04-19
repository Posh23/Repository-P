namespace ConsoleApp1.Entities;

public class Equipment : BaseEntity
{

    public string Type { get; set; }

    public string Brand { get; set; }

    public string Condition { get; set; }

    public bool Availability { get; set; }
}
