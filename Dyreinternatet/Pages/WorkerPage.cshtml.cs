using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class WorkerModel : PageModel
    {

        private readonly WorkerService _workers;

        [BindProperty]
        public List<Worker> Workers { set; get; }
        public WorkerModel(WorkerService workerS)
        {
            Workers = workerS.GetAll();

            _workers = workerS;
        }


        public void OnGet()
        {
        }
    }
}