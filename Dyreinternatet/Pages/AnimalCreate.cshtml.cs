using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class AnimalCreateModel : PageModel
    {
        
            private AnimalService _aniSer;
            [BindProperty]
            public Animal Animal { set; get; }


            public AnimalCreateModel(AnimalService aniser)
            {
                Animal = new Animal();
                _aniSer = aniser;
            }

            public void OnGet()
            {

            }
            public IActionResult OnPost()
            {
            Debug.WriteLine("test ");

            Debug.WriteLine(  Animal.Name);
            _aniSer.Add(Animal);
                return RedirectToPage("/Animals");
            }
        }
    }
