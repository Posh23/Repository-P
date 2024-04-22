namespace ConsoleApp1.Entities;

public class Equipment : BaseEntity
{

    public string Type { get; set; }

    public string Brand { get; set; }

    public string Condition { get; set; }

    public bool Availability { get; set; }

    public virtual ICollection<Studio> Studios { get; set; }
    public virtual ICollection<Magazine> Magazines { get; set; }
}
