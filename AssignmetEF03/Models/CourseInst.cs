using System.ComponentModel.DataAnnotations.Schema;

public class CourseInst
{
    public int Inst_ID { get; set; }
    public int Course_ID { get; set; }

    public string Evaluate { get; set; }

    [ForeignKey("Inst_ID")]
    public Instructor Instructor { get; set; }

    [ForeignKey("Course_ID")]
    public Course Course { get; set; }
}
