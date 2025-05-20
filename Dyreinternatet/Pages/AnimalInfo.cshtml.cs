using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class AnimalInfoModel : PageModel
    {
        public int idinfo { set; get; }
        private readonly AnimalService _animalS;


        [BindProperty]
        public List<Animal> Animals { set; get; }
        public AnimalInfoModel(AnimalService animalS)
        {
            Animals = animalS.GetAll();

            _animalS = animalS;
        }
        public void OnGet(int id)
        {
            idinfo = id;
            Debug.WriteLine(id);
        }
    }
}
