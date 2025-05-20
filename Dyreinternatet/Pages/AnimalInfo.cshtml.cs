using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class AnimalInfoModel : PageModel
    {
        int idinfo { set; get; }
        public void OnGet(int id)
        {
            idinfo = id;
            Debug.WriteLine(id);
        }
    }
}
