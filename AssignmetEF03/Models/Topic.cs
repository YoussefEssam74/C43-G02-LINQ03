using System.ComponentModel.DataAnnotations;

public class Topic
{
    [Key]
    public int ID { get; set; }

    public string Name { get; set; }
}
