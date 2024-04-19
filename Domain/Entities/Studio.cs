namespace ConsoleApp1.Entities;

public class Studio : BaseEntity
{

    public string Name { get; set; }

    public string Address { get; set; }

    public Equipment Equipment { get; set; }
    public object Staff { get; set; }
}