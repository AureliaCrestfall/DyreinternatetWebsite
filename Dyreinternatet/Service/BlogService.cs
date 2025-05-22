using Dyreinternatet.Repository;
using Dyreinternatet.Model;


namespace Dyreinternatet.Service
{
    public class BlogService
    {

        IBlogRepo _blogRepo;

        public BlogService(IBlogRepo repo)
        {
            _blogRepo = repo;
        }
        public void Add(Blog blog)
        {
            _blogRepo.Add(blog);
        }
        public void Remove(int title)
        {
            _blogRepo.Remove(title);
        }
        public List<Blog> GetAll()
        {
            return _blogRepo.GetAll();
        }
    }
}
