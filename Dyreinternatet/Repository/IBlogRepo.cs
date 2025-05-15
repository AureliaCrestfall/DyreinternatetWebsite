using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public interface IBlogRepo
    {

        List<Blog> GetAll();
        void Add();
        void Remove();
    }
}
