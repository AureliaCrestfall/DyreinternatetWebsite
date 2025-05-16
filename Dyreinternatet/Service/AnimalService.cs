using Dyreinternatet.Repository;
using Dyreinternatet.Model;
namespace Dyreinternatet.Service
{
    public class AnimalService
    {

        IAnimalRepo _animalRepo;

        public AnimalService(IAnimalRepo repo)
        {
            _animalRepo = repo;
        }

        public void Add(Animal animals)
        {
            _animalRepo.Add(animals);
        }
        public void Remove(int chipNumber)
        {
            _animalRepo.Remove(chipNumber);
        }
        public List<Animal> GetAll()
        {
            return _animalRepo.GetAll();
        }
    }
}
