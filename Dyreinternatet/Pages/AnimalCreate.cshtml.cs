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
            [BindProperty]
            public    int idcreate { set; get; }

            public AnimalCreateModel(AnimalService aniser,int idcheate)
            {
                Animal = new Animal(idcheate);
                _aniSer = aniser;
            }

            public void OnGet(int idceate)
            {
              idcreate = idceate;
            Debug.WriteLine("fefefe" + idceate);
            }
            public IActionResult OnPost()
            {
            //Debug.WriteLine("fefe" + idcreate);
            //Animal.ChipNumber = idcreate;
            _aniSer.Add(Animal);
                return RedirectToPage("/Animals");
            }
        }
    }
