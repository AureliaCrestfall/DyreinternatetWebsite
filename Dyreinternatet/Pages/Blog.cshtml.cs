using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Dyreinternatet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class BlogModel : PageModel
    {
        private readonly BlogService _blogService;
        public string titleCreate = " ";
        public int idinfo = 0;
        [BindProperty]
        public List <Blog> Blogs { get; set; }
        public BlogModel (BlogService blogService)
        {
            Blogs = blogService.GetAll();
            _blogService = blogService; 
            foreach(Blog blog in Blogs)
            {
                idinfo++;
            }
        }
        public void OnGet()
        {

        }
    }
}
