using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class ActivityModel : PageModel
    {

        private readonly ActivityService _activityService;

        public string titleCreate = " ";
        [BindProperty]
        public List<Activity> Activities { get; set; }

        public ActivityModel(ActivityService activityService)
        {
            Activities = activityService.GetAll();
            _activityService = activityService;
        }
        public void OnGet()
        {
        }
    }
}
