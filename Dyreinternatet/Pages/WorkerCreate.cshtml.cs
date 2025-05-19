using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class WorkerCreateModel : PageModel
    {

        private WorkerService _workSer;
        [BindProperty]
        public Worker Worker { set; get; }


        public WorkerCreateModel(WorkerService workser)
        {
            Worker = new Worker();
            _workSer = workser;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {

            _workSer.Add(Worker);
            return RedirectToPage("/WorkerPage");
        }
    }
}

