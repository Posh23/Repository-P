using System.Collections;

namespace Domain.Entities;

public class Client : BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public virtual ICollection<PhotoSession> PhotoSessions  { get; set; }
 
}