namespace ConsoleApp1.Entities;

public class Studio : BaseEntity
{

    public string Name { get; set; }

    public string Address { get; set; }

    public Equipment Equipments { get; set; }
    public Guid EquipmentId { get; set; }
    public virtual ICollection<Staff> Staffs { get; set; }
}