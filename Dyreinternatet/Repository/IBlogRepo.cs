using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public interface IBlogRepo
    {
        /// <summary>
        /// All the methods that need to be implemented to use this interface
        /// </summary>
        List<Blog> GetAll();
        void Add(Blog blog);
        void Remove(int title);
        void Edit(int place, Blog editblog);

    }
}
