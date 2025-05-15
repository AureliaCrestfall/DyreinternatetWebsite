using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public class BlogRepo:IBlogRepo
    {

        List<Blog> _blogs;

        protected List<Blog> Blogs
        {
            get { return _blogs; }
            set { _blogs = value; }
        }

        public List<Blog> GetAll()
        {
            return Blogs;
        }
        public void Add(Blog blog)
        {
            Blogs.Add(blog);
        }

        public void Remove(int title)
        {
            Blogs.RemoveAt(title);
        }


    }
}
