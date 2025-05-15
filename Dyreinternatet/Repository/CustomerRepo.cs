using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class CustomerRepo:ICustomerRepo
    {

        List<Customer> _customers;

        protected List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public List<Customer> GetAll()
        {
            return Customers;
        }

        public void Add(Customer customer)
        {
            Customers.Add(customer);
        }

        public void Remove(int phoneNumber)
        {
            Customers.RemoveAt(phoneNumber);
        }

    }
}
