using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public interface IBlogRepo
    {

        List<Blog> GetAll();
        void Add(Blog blog);
        void Remove(int title);
        void Edit(int place, Blog editblog);

    }
}
