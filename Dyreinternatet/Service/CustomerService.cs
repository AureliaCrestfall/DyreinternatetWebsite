using Dyreinternatet.Model;
using Dyreinternatet.Repository;
namespace Dyreinternatet.Service
{
    public class CustomerService
    {
        ICustomerRepo _customerRepo;
        public CustomerService(ICustomerRepo CustomerRepo)
        {
            _customerRepo = CustomerRepo;
        }

        public void Add(Customer customer)
        {
            _customerRepo.Add(customer);
        }
        public void Remove(int phoneNumber)
        {
            _customerRepo.Remove(phoneNumber);
        }
        public List<Customer> GetAll()
        {
            return _customerRepo.GetAll();
        }

    }
}
