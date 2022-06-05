namespace OfficeControl;

public class Employee : Person
{
    public Division Division { get; set; }
    public decimal Salary { get; set; }

    public void CopyFrom(Employee employee)
    {
        this.Name = employee.Name;
        this.Age = employee.Age;
        this.Division = employee.Division;
        this.Salary = employee.Salary;
    }
}
