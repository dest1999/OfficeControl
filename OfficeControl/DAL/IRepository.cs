namespace OfficeControl
{
    public interface IRepository<T> where T : Employee
    {
        void Create(T human);
        T Read(string name);
        void Update(T human);
        bool Delete(string name);
        IEnumerable<T> GetAll();
        T? GetById(int id);
    }
}
