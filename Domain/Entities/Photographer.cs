namespace Domain.Entities;

public class Photographer : BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }

    public string Specialty { get; set; }
    public PhotoSession PhotoSessions { get; set; }
    public Guid PhotoSessionId { get; set; }


}