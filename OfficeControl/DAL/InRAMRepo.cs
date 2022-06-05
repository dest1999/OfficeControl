﻿namespace OfficeControl;

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
    public Employee? Read(string name)
    {
        return employees.FirstOrDefault(e => e.Name == name);
    }

    public void Update(Employee human)
    {
        var tmpEmployee = GetById(human.Id);
        if (tmpEmployee != null)
        {
            tmpEmployee.CopyFrom(human);
        }
    }

    public bool Delete(int id)
    {
        var deletedQty = employees.RemoveAll(e => e.Id == id);
        if (deletedQty > 0)
        {
            return true;
        }
        return false;
    }

    public IEnumerable<Employee> GetAll() => employees;

    public Employee? GetById(int id) => employees.FirstOrDefault(e => e.Id == id);



}
