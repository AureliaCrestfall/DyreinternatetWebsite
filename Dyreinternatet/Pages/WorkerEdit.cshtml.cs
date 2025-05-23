using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class WorkerEditModel : PageModel
    {
        public int idinfo { set; get; }

        private readonly WorkerService _workSer;
        [BindProperty]

        public Worker Worker { set; get; }




        [BindProperty]
        public List<Worker> Workers { set; get; }

        public WorkerEditModel(WorkerService workerService)
        {
            Workers = workerService.GetAll();
            Worker = new Worker();
            _workSer = workerService;
        }
        public void OnGet(int id)
        {
            idinfo = id;
            Debug.WriteLine(id);
        }
        public IActionResult OnPost(int idinfo)
        {
            //Blog.ImagePath = Blogs[idinfo].ImagePath;
            _workSer.Edit(idinfo, Worker);

            return RedirectToPage("/Worker");
        }
    }
}
