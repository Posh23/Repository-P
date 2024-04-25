namespace Domain.Entities;

public class Staff : BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string Position { get; set; }

    public Studio Studios { get; set; }
    public Guid StudioId { get; set; }
}