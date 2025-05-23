using Dyreinternatet.Repository;
using Dyreinternatet.Model;
using System.Diagnostics;
using System.Text;
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
            try
            {
                _animalRepo.Remove(chipNumber);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public List<Animal> GetAll()
        {
            return _animalRepo.GetAll();
        }
      

        public void AddVisits(int chipNumber, string visits)
        {
            _animalRepo.AddVisits(chipNumber, visits);
        }
        public List<Animal> Filter(string species, string gender)
        {
            return _animalRepo.Filter(species, gender);
        }

       public List<Animal> Sort()
        {
            
            
            
            return _animalRepo.Sort();
        }

        public List<Animal> sherch(string shearchName)
        {
            
                return _animalRepo.sherch(shearchName);

            

        }
        public void Edit(int place, Animal editanimal)
        {
            _animalRepo.Edit(place, editanimal);
        }



    }
}

