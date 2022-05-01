using System.ComponentModel.DataAnnotations;

namespace OfficeControl;

public class Person
{
    [Required]
    public string Name { get; set; }
    public int Age { get; set; }

}
