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

        public List <Animal> FilteredAnimals {get; set;}
        [BindProperty]

        public bool dog { set; get; }
        public string Species { get; set;}
        [BindProperty]

        public string Gender { get; set;}


        [BindProperty]
        public List<Animal> Animals { set; get; }
        public AnimalsModel(AnimalService animalS)
        {
            Animals = animalS.GetAll();
            //FilteredAnimals = animalS.GetAllFilteredAnimals();
            _animalS = animalS;
            foreach(Animal animal in Animals)
            {
                idceate++;
            }
        }
        public void OnPostFilter()
        {
            if (dog == true)
            {
                Species = "hund";
            }
            Animals = _animalS.Filter(Species, Gender);
            //FilteredAnimals = _animalS.GetAllFilteredAnimals();
            //Animals = _animalS.GetAllFilteredAnimals(); 
        }
       
        public void OnGet()
        {
        }
        public void OnPostSort()
        {
            List<Animal> sortanimals = _animalS.GetAll();
            Debug.WriteLine("sort test" + sortanimals[2].Name);
            Animals=_animalS.Sort(sortanimals);
         
        }
    }
}
