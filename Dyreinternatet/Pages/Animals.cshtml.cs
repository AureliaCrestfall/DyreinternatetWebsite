using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Dyreinternatet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class AnimalsModel : PageModel
    {

        private readonly AnimalService _animalS;
        public  int idceate = 0;


        [BindProperty]
        public List<Animal> Animals { set; get; }
        public AnimalsModel(AnimalService animalS)
        {
            Animals = animalS.GetAll();

            _animalS = animalS;
            foreach(Animal animal in Animals)
            {
                idceate++;
            }
        }
        
       
        public void OnGet()
        {
        }
        public void OnPostSort()
        {
            Debug.WriteLine("sort test");
         _animalS.Sort(Animals);
         
        }
    }
}
