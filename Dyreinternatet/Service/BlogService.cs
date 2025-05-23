using Dyreinternatet.Repository;
using Dyreinternatet.Model;


namespace Dyreinternatet.Service
{
    public class BlogService
    {

        IBlogRepo _blogRepo;
        Random rnd = new Random();

        public string rndimage(string folder)
        {
            string[] paths = Directory.GetFiles(folder);
            int rndint = rnd.Next(paths.Length);
            return paths[rndint];
        }
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
        public void Edit(int place, Blog editblog)
        {
            _blogRepo.Edit(place, editblog);
        }
    }
}
