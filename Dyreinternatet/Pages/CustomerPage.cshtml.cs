using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class CustomerPageModel : PageModel
    {

        private readonly CustomerService _customers;

        [BindProperty]
        public List<Customer> Customers { set; get; }
        public CustomerPageModel(CustomerService customerS)
        {
            Customers = customerS.GetAll();

            _customers = customerS;
        }


        public void OnGet()
        {
        }
    }
}
