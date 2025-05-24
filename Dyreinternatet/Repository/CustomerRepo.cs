using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class CustomerRepo:ICustomerRepo
    {
        /// <summary>
        /// instancing the list of Customer
        /// </summary>
        List<Customer> _customers;
        /// <summary>
        /// default constructor
        /// </summary>
        public CustomerRepo()
        {
            _customers = new List<Customer>();
            seed();
        }
       
        /// <summary>
        /// Method for getting all customers from list Customer
        /// </summary>
        /// <returns>list of _customers</returns>
        public List<Customer> GetAll()
        {
            return _customers;
        }
        /// <summary>
        /// adds customer to the list of Customer
        /// </summary>
        /// <param name="customer">name of the class that gets added to the list _customers</param>
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }
        /// <summary>
        /// removes a customer using phone number as an ID of placement
        /// </summary>
        /// <param name="phoneNumber">used to specify placement in list</param>
        public void Remove(int phoneNumber)
        {
            _customers.RemoveAt(phoneNumber);
        }
        /// <summary>
        /// Method for adding customers to the list, default and specified customers
        /// </summary>
        void seed()
        { 
            _customers.Add(new Customer("John Doe", "123456", "johndoe@gmail.com", "himmerlandsvej 69"));
            _customers.Add(new Customer("Luka Magnotta", "123456", "IloveKittens@gmail.com", "Maglegårdsvej 17"));
        }
        /// <summary>
        /// method for editing customer at current placement
        /// </summary>
        /// <param name="place">placement of customer in list</param>
        /// <param name="editCustomer">adds the edited values to the placement</param>
        public void Edit(int place, Customer editCustomer)
        {
            _customers[place] = editCustomer;
        }
    }
}
