using Dyreinternatet.Model;
using Dyreinternatet.Service;
//using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class ActivityEditModel : PageModel
    {

        public int idinfo { set; get; }

        private readonly ActivityService _activityService;
        [BindProperty]

        public Activity Activity { set; get; }




        [BindProperty]
        public List<Activity> Activities { set; get; }

        public ActivityEditModel(ActivityService activityService)
        {
            Activities = activityService.GetAll();
            Activity = new Activity();
            _activityService = activityService;
        }
        public void OnGet(int id)
        {
            idinfo = id;
            //Debug.WriteLine(id);
        }
        public IActionResult OnPost(int idinfo)
        {
            //Blog.ImagePath = Blogs[idinfo].ImagePath;
            _activityService.Edit(idinfo, Activity);

            return RedirectToPage("/Activity");
        }
        
    }
}
