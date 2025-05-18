using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Dyreinternatet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class AnimalsModel : PageModel
    {

        private readonly AnimalService _animalS;

        [BindProperty]
        public List<Animal> Animals { set; get; }
        public AnimalsModel(AnimalService animalS)
        {
            Animals = animalS.GetAll();

            _animalS = animalS;
        }
        

        public void OnGet()
        {
        }
    }
}
