using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class AnimalsModel : PageModel
    {

        private readonly AnimalService _animalS;

        public AnimalsModel(AnimalService animalS)
        {
            _animalS = animalS;
        }

        public List<Animal> Animals { set; get; }

        public void OnGet()
        {
            Animals = _animalS.GetAll();
        }
    }
}
