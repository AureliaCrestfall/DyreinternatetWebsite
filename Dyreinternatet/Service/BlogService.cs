using Dyreinternatet.Repository;
using Dyreinternatet.Model;


namespace Dyreinternatet.Service
{
    public class BlogService
    {
        /// <summary>
        /// implementing the interface
        /// </summary>
        IBlogRepo _blogRepo;
        /// <summary>
        /// variable for the random used for the imagepaths
        /// </summary>
        Random rnd = new Random();
        /// <summary>
        /// Method for adding random image to the blogs created
        /// </summary>
        /// <param name="folder">path of the folder that the images are in</param>
        /// <returns>random imagepath to the integer of paths</returns>
        public string rndimage(string folder)
        {
            string[] paths = Directory.GetFiles(folder);
            int rndint = rnd.Next(paths.Length);
            return paths[rndint];
        }
        /// <summary>
        /// constructor for implementing interface
        /// </summary>
        /// <param name="repo">name of the implemented interface</param>
        public BlogService(IBlogRepo repo)
        {
            _blogRepo = repo;
        }
        /// <summary>
        /// method for adding blogs to the repository
        /// </summary>
        /// <param name="blog">name of the list that gets blogs added to the repository</param>
        public void Add(Blog blog)
        {
            _blogRepo.Add(blog);
        }
        /// <summary>
        /// removes blog at specified location in list
        /// </summary>
        /// <param name="title">specifies the location of the blog to be removed</param>
        public void Remove(int title)
        {
            _blogRepo.Remove(title);
        }
        /// <summary>
        /// method for getting all blogs in the list
        /// </summary>
        /// <returns>all the content from the _blogs list in repository</returns>
        public List<Blog> GetAll()
        {
            return _blogRepo.GetAll();
        }
        /// <summary>
        /// method for editing blogs at specified location in list
        /// </summary>
        /// <param name="place">placement of the blog in the list</param>
        /// <param name="editblog">adds the edited values to the placement</param>
        public void Edit(int place, Blog editblog)
        {
            _blogRepo.Edit(place, editblog);
        }
    }
}
