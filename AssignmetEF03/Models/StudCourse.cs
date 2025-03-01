using System.ComponentModel.DataAnnotations.Schema;

public class StudCourse
{
    public int Stud_ID { get; set; }
    public int Course_ID { get; set; }

    public string Grade { get; set; }

    [ForeignKey("Stud_ID")]
    public Student Student { get; set; }

    [ForeignKey("Course_ID")]
    public Course Course { get; set; }
}
