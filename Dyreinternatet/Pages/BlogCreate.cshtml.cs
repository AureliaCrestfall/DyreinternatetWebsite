using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class BlogCreateModel : PageModel
    {
        private BlogService _blogSer;
        [BindProperty]
        public Blog Blog { get; set; }

        public BlogCreateModel(BlogService blogSer)
        {
            Blog = new Blog();
            _blogSer = blogSer;
        }
        public void OnGet()
        {
        }
    }
}
