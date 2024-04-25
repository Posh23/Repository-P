namespace Domain.Entities;

public class Studio : BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string Address { get; set; }

    public Equipment Equipments { get; set; }
    public Guid EquipmentId { get; set; }
    public virtual ICollection<Staff> Staffs { get; set; }
}