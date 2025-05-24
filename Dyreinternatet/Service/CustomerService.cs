using Dyreinternatet.Model;
using Dyreinternatet.Repository;
namespace Dyreinternatet.Service
{
    public class CustomerService
    {
        /// <summary>
        /// implementing the interface
        /// </summary>
        ICustomerRepo _customerRepo;
        /// <summary>
        /// implementing the interface in a default constructor
        /// </summary>
        /// <param name="CustomerRepo">name of the implemented interface</param>
        public CustomerService(ICustomerRepo CustomerRepo)
        {
            _customerRepo = CustomerRepo;
        }
        /// <summary>
        /// method for adding customer to the list of _customerRepo in repository
        /// </summary>
        /// <param name="customer">name of the class that gets added to the list </param>
        public void Add(Customer customer)
        {
            _customerRepo.Add(customer);
        }
        /// <summary>
        /// method for removing customer at specified placement in list
        /// </summary>
        /// <param name="phoneNumber">used for ID of placement in list</param>
        public void Remove(int phoneNumber)
        {
            _customerRepo.Remove(phoneNumber);
        }
        /// <summary>
        /// method for getting the list of Customer from the repository
        /// </summary>
        /// <returns>content of the list in repository</returns>
        public List<Customer> GetAll()
        {
            return _customerRepo.GetAll();
        }
        /// <summary>
        /// method for editing info on customer from specified placement in list
        /// </summary>
        /// <param name="place">used for choosing the placement in list</param>
        /// <param name="editCustomer">new values that get added to the chosen customer</param>
        public void Edit(int place, Customer editCustomer)
        {
            _customerRepo.Edit(place, editCustomer);
        }
    }
}
