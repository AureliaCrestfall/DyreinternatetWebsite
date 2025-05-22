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
            _animalRepo.Remove(chipNumber);
        }
        public List<Animal> GetAll()
        {
            return _animalRepo.GetAll();
        }
        //public List<Animal> GetAllFilteredAnimals()
        //{
        //    return _animalRepo.GetAllFilteredAnimals();
        //}

        public void AddVisits(int chipNumber, string visits)
        {
            _animalRepo.AddVisits(chipNumber, visits);
        }
        public List<Animal> Filter(string species, string gender)
        {
            return _animalRepo.Filter(species, gender);
        }

       public List<Animal> Sort(List<Animal> bubble)
        {
            
            bool swapped = true;
            int n = 0;
            foreach(Animal animal in bubble)
            {
                n++;
            }
            while (swapped != false)
            {

                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (bubble[i].Age > bubble[i + 1].Age)
                    {
                        (bubble[i], bubble[i + 1]) = (bubble[i + 1], bubble[i]);
                        
                        swapped = true;
                    }
                }
            }
            for (int i = 0; i < n ; i++)
            {
                bubble[i].ID = i;
            }
            
            return bubble;
        }

        public List<Animal> sherch(string shearchName)
        {
            return _animalRepo.sherch(shearchName);
        }
             

    }
}

