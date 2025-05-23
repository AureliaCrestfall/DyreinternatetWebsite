using Dyreinternatet.Model;
using Dyreinternatet.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dyreinternatet.Pages
{
    public class CustomerEditModel : PageModel
    {
        public int idinfo { set; get; }

        private readonly CustomerService _custSer;
        [BindProperty]

        public Customer Customer { set; get; }




        [BindProperty]
        public List<Customer> Customers { set; get; }

        public CustomerEditModel(CustomerService customerService)
        {
            Customers = customerService.GetAll();
            Customer = new Customer();
            _custSer = customerService;
        }
        public void OnGet(int id)
        {
            idinfo = id;
            Debug.WriteLine(id);
        }
        public IActionResult OnPost(int idinfo)
        {
            //Blog.ImagePath = Blogs[idinfo].ImagePath;
            _custSer.Edit(idinfo, Customer);

            return RedirectToPage("/Customer");
        }
    }
}
