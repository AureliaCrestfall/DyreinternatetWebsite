using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternatet.Pages
{
    public class CustomerCreateModel : PageModel
    {

        private CustomerService _customerSer;
        [BindProperty]
        public Customer Customer { set; get; }


        public CustomerCreateModel(CustomerService customerser)
        {
            Customer = new Customer();
            _customerSer = customerser;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {

            _customerSer.Add(Customer);
            return RedirectToPage("/CustomerPage");
        }
    }
}
