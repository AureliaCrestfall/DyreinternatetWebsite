using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class AnimalEditModel : PageModel
    {
        public int idinfo { set; get; }

        private readonly AnimalService _animalS;
        [BindProperty]

        public Animal Animal { set; get; }




        [BindProperty]
        public List<Animal> Animals { set; get; }

        public AnimalEditModel(AnimalService animalS)
        {
            Animals = animalS.GetAll();
            Animal = new Animal();
            _animalS = animalS;
        }
        public void OnGet(int id)
        {
            idinfo = id;
            Debug.WriteLine(id);
        }
        public IActionResult OnPost(int idinfo)
        {
            _animalS.Edit(idinfo,Animal);

            return RedirectToPage("/Animals");
        }
    }
}
