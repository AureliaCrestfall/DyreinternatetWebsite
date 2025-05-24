using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public class BlogRepo:IBlogRepo
    {
        /// <summary>
        /// instancing the list of _blog
        /// </summary>
        private List<Blog> _blogs;
        /// <summary>
        /// default constructor for the Blog using seed method
        /// </summary>
        public BlogRepo()
        {
            _blogs = new List<Blog>();
            seed();
        }
        /// <summary>
        /// instancing the list of Blogs
        /// </summary>
        public List<Blog> Blogs
        {
            get { return _blogs; }
            set { _blogs = value; }
        }
        /// <summary>
        /// Method for getting all the content of the list Blog
        /// </summary>
        /// <returns>list _blogs</returns>
        public List<Blog> GetAll()
        {
            return _blogs;
        }
        /// <summary>
        /// Method for adding blogs to the list
        /// </summary>
        /// <param name="blog">name of the class that gets added to the list Blogs</param>
        public void Add(Blog blog)
        {
            Blogs.Add(blog);
        }
        /// <summary>
        /// removes a blog from the specified placement in list using title value
        /// </summary>
        /// <param name="title">shows placement in list</param>
        public void Remove(int title)
        {
            Blogs.RemoveAt(title);
        }
        /// <summary>
        /// method for adding blogs to the list using default constructor
        /// </summary>
        void seed()
        {
            _blogs.Add(new Blog());
        }
        /// <summary>
        /// method for editing blog at current placement
        /// </summary>
        /// <param name="place">placement of the blog based off id</param>
        /// <param name="editblog">adds the edited values to the list</param>
        public void Edit(int place, Blog editblog)
        {
            editblog.ImagePath = _blogs[place].ImagePath;
            _blogs[place] = editblog;
        }

    }
}
