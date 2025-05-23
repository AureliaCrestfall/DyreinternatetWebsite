using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class BlogEditModel : PageModel
    {
        public int idinfo { set; get; }

        private readonly BlogService _blogSer;
        [BindProperty]

        public Blog Blog { set; get; }




        [BindProperty]
        public List<Blog> Blogs { set; get; }

        public BlogEditModel(BlogService blogService)
        {
            Blogs = blogService.GetAll();
            Blog = new Blog();
            _blogSer = blogService;
        }
        public void OnGet(int id)
        {
            idinfo = id;
            Debug.WriteLine(id);
        }
        public IActionResult OnPost(int idinfo)
        {
            //Blog.ImagePath = Blogs[idinfo].ImagePath;
            _blogSer.Edit(idinfo, Blog);

            return RedirectToPage("/Blog");
        }
    }
}
