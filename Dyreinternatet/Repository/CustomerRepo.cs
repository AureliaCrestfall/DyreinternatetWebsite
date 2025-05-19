using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class CustomerRepo:ICustomerRepo
    {

        List<Customer> _customers;

        public CustomerRepo()
        {
            _customers = new List<Customer>();
        }
        //protected List<Customer> Customers
        //{
        //    get { return _customers; }
        //    set { _customers = value; }
        //}

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Remove(int phoneNumber)
        {
            _customers.RemoveAt(phoneNumber);
        }

    }
}
