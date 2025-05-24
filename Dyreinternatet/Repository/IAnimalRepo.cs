using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public interface IAnimalRepo
    {
        /// <summary>
        /// All the methods that need to be implemented to use this interface
        /// </summary>
        List<Animal> GetAll();
        void Add(Animal animals);
        void Remove(int chipNumber);
        void AddVisits(int chipNumber, string visits);
        List<Animal> Filter(string species, string gender);
        List<Animal> sherch(string shearchName);
        void Edit(int place, Animal editanimal);
        List<Animal> Sort();
    }
}
