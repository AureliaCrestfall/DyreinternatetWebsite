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
        public string searchname { set; get; }
        [BindProperty]
        public bool dog { set; get; }
        [BindProperty]
        public bool cat { set; get; }
        [BindProperty]
        public bool rabbit { set; get; }
        [BindProperty]
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
            if (cat == true)
            {
                Species = "kat";
            }
            if (rabbit == true)
            {
                Species = "kanin";
            }
            if (dog == true && cat == true)
            {
                Species = "hundkat";
            }
            if (dog == true && rabbit == true)
              {
                    Species = "hundkanin";
              }

               if(cat == true && rabbit == true)
               {
                    Species = "katkanin";
               }
            if (dog == true && cat == true && rabbit == true)
            {
                Species = "hundkatkanin";
            }
            Animals = _animalS.Filter(Species, Gender);
            //FilteredAnimals = _animalS.GetAllFilteredAnimals();
            //Animals = _animalS.GetAllFilteredAnimals(); 
        }
       public void OnPostSearch()
        {
            //try
            //{
                Animals = _animalS.sherch(searchname);
            //}
            //catch(Exception ex)
            //{
            //    Debug.WriteLine("no animals");
            //}
        }
        public void OnGet()
        {
        }
        public void OnPostSort()
        {
           
            Animals=_animalS.Sort();
         
        }
        public IActionResult OnPostDeleteAnimal(int ID)
        {
            _animalS.Remove(ID);


            return RedirectToPage();


        }
    }
}
