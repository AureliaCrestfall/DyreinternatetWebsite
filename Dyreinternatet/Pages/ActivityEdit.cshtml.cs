using Dyreinternatet.Model;
using Dyreinternatet.Service;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class ActivityEditModel : PageModel
    {

        public int idinfo { set; get; }

        private readonly ActivityService _activityService;
        [BindProperty]

        public Model.Activity Activity { set; get; }




        [BindProperty]
        public List<Model.Activity> Activities { set; get; }

        public ActivityEditModel(ActivityService activityService)
        {
            Activities = activityService.GetAll();
            Activity = new Model.Activity();
            _activityService = activityService;
        }
        public void OnGet(int id)
        {
            idinfo = id;
            //Debug.WriteLine(id);
        }
        public IActionResult OnPost(int idinfo)
        {

            Debug.WriteLine(idinfo + "test"+ Activity.Title);
            //Blog.ImagePath = Blogs[idinfo].ImagePath;
            _activityService.Edit(idinfo, Activity);

            return RedirectToPage("/Activity");
        }
        
    }
}
