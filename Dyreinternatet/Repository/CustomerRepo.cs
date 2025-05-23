using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class CustomerRepo:ICustomerRepo
    {

        List<Customer> _customers;

        public CustomerRepo()
        {
            _customers = new List<Customer>();
            seed();
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
        void seed()
        { 
            _customers.Add(new Customer("John Doe", "123456", "johndoe@gmail.com", "himmerlandsvej 69"));
            _customers.Add(new Customer("Luka Magnotta", "123456", "IloveKittens@gmail.com", "Maglegårdsvej 17"));
        }
        public void Edit(int place, Customer editCustomer)
        {
            _customers[place] = editCustomer;
        }
    }
}
