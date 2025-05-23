using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class ActivityCreateModel : PageModel
    {
        private BlogService _activityService;
        [BindProperty]
        public Activity Activity { get; set; }
        [BindProperty]
        public string TitleCreate { get; set; }

        public ActivityCreateModel(ActivityService activityService)
        {
            Activity = new Activity();
            _activityService = activityService;
        }
        public void OnGet(string titleCreate)
        {
            TitleCreate = titleCreate;
        }
        public IActionResult OnPost()
        {
            string folderlocation = "Image/";
            Activity.ImagePath = _activityService.rndimage(folderlocation);
            _activityService.Add(Activity);

            return RedirectToPage("/Activity");
        }
        
    }
}
