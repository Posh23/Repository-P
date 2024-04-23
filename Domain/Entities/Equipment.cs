namespace Domain.Entities;

public class Equipment : BaseEntity
{
    public Guid Id { get; set; }
    public string Type { get; set; }

    public string Brand { get; set; }

    public string Condition { get; set; }

    public bool Availability { get; set; }

    public virtual ICollection<Studio> Studios { get; set; }
    public virtual ICollection<Magazine> Magazines { get; set; }
}
