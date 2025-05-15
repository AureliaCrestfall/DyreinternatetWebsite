using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public interface IAnimalRepo
    {

        List<Animal> GetAll();
        void Add();
        void Remove();
    }
}
