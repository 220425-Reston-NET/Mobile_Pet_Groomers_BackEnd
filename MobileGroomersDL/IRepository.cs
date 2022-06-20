namespace MobileGroomersDL
{
    public interface IRepository<T> 
    {
        // void Add(T c_resource);
        void Add(T p_resource);

        List<T> GetAll();
        void Update(T p_resource);
    }
}