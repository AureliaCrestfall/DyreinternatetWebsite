using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Xml.Linq;

namespace Dyreinternatet.Pages
{
    public class AnimalBookingModel : PageModel
    {
        public int idbook { set; get; }
        public string visit { set; get; }

        private readonly AnimalService _animalS;
        [BindProperty]

        public Animal Animal { set; get; }





        public AnimalBookingModel(AnimalService animalS)
        {
            Animal = new Animal();
            _animalS = animalS;
        }
        public void OnGet(int id)
        {
            idbook = id;
        }
        public IActionResult OnPost(int idbook)
        {

            visit = Animal.ImgPath;
            Debug.WriteLine(visit);
            Debug.WriteLine(idbook);

            _animalS.AddVisits(idbook, visit);

            return RedirectToPage("/Animals");
        }
    }
}
