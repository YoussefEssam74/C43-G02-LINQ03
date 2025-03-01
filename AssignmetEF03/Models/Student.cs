using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int ID { get; set; }

    [Required, MaxLength(50)]
    public string FName { get; set; }

    [Required, MaxLength(50)]
    public string LName { get; set; }

    [MaxLength(255)]
    public string Address { get; set; }

    [Range(18, 100)]
    public int Age { get; set; }

    public int Dep_Id { get; set; }

    [ForeignKey("Dep_Id")]
    public Department Department { get; set; }

    public ICollection<StudCourse> StudCourses { get; set; } = new List<StudCourse>();
}
