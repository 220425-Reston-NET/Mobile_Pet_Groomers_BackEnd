using MobileGoomersModels;

namespace MobileGroomersDL
{
    public interface IRepository<T>
    {
        void Add(T c_resource);

        List<T> GetAll();
    }
}