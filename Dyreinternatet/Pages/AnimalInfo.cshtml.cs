using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class AnimalInfoModel : PageModel
    {
        public void OnGet(int id)
        {
            Debug.WriteLine(id);
        }
    }
}
