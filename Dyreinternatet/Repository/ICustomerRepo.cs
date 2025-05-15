using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public interface ICustomerRepo
    {
        List<Customer> GetAll();
        void Add();
        void Remove();
    }
}
