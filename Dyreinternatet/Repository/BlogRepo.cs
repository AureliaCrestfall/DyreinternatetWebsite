using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public class BlogRepo:IBlogRepo
    {

        private List<Blog> _blogs;
        public BlogRepo()
        {
            _blogs = new List<Blog>();
            seed();
        }

        public List<Blog> Blogs
        {
            get { return _blogs; }
            set { _blogs = value; }
        }

        public List<Blog> GetAll()
        {
            return _blogs;
        }
        public void Add(Blog blog)
        {
            Blogs.Add(blog);
        }

        public void Remove(int title)
        {
            Blogs.RemoveAt(title);
        }
        void seed()
        {
            _blogs.Add(new Blog());
        }


    }
}
