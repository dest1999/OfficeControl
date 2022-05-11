using System.ComponentModel.DataAnnotations;

namespace OfficeControl;

public class Person
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual string ToString()
    {
        return Name;
    }
}
