namespace OfficeControl;

public class InRAMRepo : IRepository<Employee>
{
    private readonly List<Employee> employees = new()
    { 
        new Employee() { Id = 1, Name = "Alex", Age = 30, Division = Division.Shop, Salary = 100500 },
        new Employee() { Id = 2, Name = "Bob", Age = 22 },
        new Employee() { Id = 3, Name = "Catherine", Age = 27 }
    };
    public void Create(Employee human)
    {
        human.Id = 1 + employees[^1].Id;
        employees.Add(human);
    }

    public bool Delete(string name)
    {
        var deletedQty = employees.RemoveAll(e => e.Name == name);
        if (deletedQty > 0)
        {
            return true;
        }
        return false;
    }

    public IEnumerable<Employee> GetAll() => employees;

    public Employee? Read(string name)
    {
        return employees.FirstOrDefault(e => e.Name == name);
    }

    public void Update(Employee human)
    {
        throw new NotImplementedException();
    }




}
