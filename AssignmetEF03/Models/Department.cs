using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Department
{
    [Key]
    public int ID { get; set; }

    public string Name { get; set; }

    public int Ins_ID { get; set; }

    [ForeignKey("Ins_ID")]
    public Instructor Instructor { get; set; }

    public DateTime HiringDate { get; set; }

    public ICollection<Student> Students { get; set; } = new List<Student>();
}
