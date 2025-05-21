using Dyreinternatet.Repository;
using Dyreinternatet.Model;
using System.Diagnostics;
namespace Dyreinternatet.Service
{
    public class AnimalService
    {
        Random rnd = new Random();

        IAnimalRepo _animalRepo;

        public string rndimage(string folder)
        {
            string[] paths = Directory.GetFiles(folder);
            int rndint = rnd.Next(paths.Length);
           return paths[rndint];
        }

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
        public List<Animal> GetAllFilteredAnimals()
        {
            return _animalRepo.GetAllFilteredAnimals();
        }

        public void AddVisits(int chipNumber, string visits)
        {
            _animalRepo.AddVisits(chipNumber, visits);
        }
        public void Filter(string species, string gender)
        {
            _animalRepo.Filter(species, gender);
        }
    }
}

//dlkkldfnglrtg