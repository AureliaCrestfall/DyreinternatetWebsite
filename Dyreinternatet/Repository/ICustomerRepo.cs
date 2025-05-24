using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public interface ICustomerRepo
    {
        /// <summary>
        /// All the methods that need to be implemented to use this interface
        /// </summary>
        List<Customer> GetAll();
        void Add(Customer customer);
        void Remove(int phoneNumber);
        void Edit(int place, Customer editCustomer);

    }
}
