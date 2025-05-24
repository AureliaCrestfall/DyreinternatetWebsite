using Dyreinternatet.Repository;
using Dyreinternatet.Model;
using System.Diagnostics;
using System.Text;
namespace Dyreinternatet.Service
{
    public class AnimalService
    {
        /// <summary>
        /// variable for the random used for the imagepaths
        /// </summary>
        Random rnd = new Random();
        /// <summary>
        /// implementing the interface
        /// </summary>
        IAnimalRepo _animalRepo;
        /// <summary>
        /// Method for adding random image to the animals created
        /// </summary>
        /// <param name="folder">path of the folder that the images are in</param>
        /// <returns>random imagepath to the integer of paths</returns>
        public string rndimage(string folder)
        {
            string[] paths = Directory.GetFiles(folder);
            int rndint = rnd.Next(paths.Length);
           return paths[rndint];
        }
        /// <summary>
        /// constructor for implementing interface
        /// </summary>
        /// <param name="repo">name for using the interface</param>
        public AnimalService(IAnimalRepo repo)
        {
            _animalRepo = repo;
        }
        /// <summary>
        /// Method for adding animals to the animal repository
        /// </summary>
        /// <param name="animals">Name of the new list that gets animals added to the repository</param>
        public void Add(Animal animals)
        {
            _animalRepo.Add(animals);
        }
        /// <summary>
        /// Method for removing animals from the animal repository
        /// </summary>
        /// <param name="chipNumber">number used for placement of the animal in the list</param>
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
        /// <summary>
        /// Method for getting all the animals in the list
        /// </summary>
        /// <returns>List of all animals in the repository</returns>
        public List<Animal> GetAll()
        {
            return _animalRepo.GetAll();
        }
      
        /// <summary>
        /// Method for adding visits to the animal
        /// </summary>
        /// <param name="chipNumber">shows the ID of the animal</param>
        /// <param name="visits">used to store the visits for the animal</param>
        public void AddVisits(int chipNumber, string visits)
        {
            _animalRepo.AddVisits(chipNumber, visits);
        }
        /// <summary>
        /// Method for filtering in the animals
        /// </summary>
        /// <param name="species">Species of the animal</param>
        /// <param name="gender">Gender of the animal (unused)</param>
        /// <returns>a filtered list of animals based off the variable species</returns>
        public List<Animal> Filter(string species, string gender)
        {
            return _animalRepo.Filter(species, gender);
        }
        /// <summary>
        /// method that sorts through the animal list based off age
        /// </summary>
        /// <returns>a sorted list of animals from youngest to oldest</returns>
       public List<Animal> Sort()
        {
            
            
            
            return _animalRepo.Sort();
        }
        /// <summary>
        /// Method for searching through the list of animals from the name
        /// </summary>
        /// <param name="shearchName">the string that gets searched for in the list</param>
        /// <returns>All animals that fit the search term</returns>
        public List<Animal> sherch(string shearchName)
        {
            
                return _animalRepo.sherch(shearchName);

            

        }
        /// <summary>
        /// Method for editing in the animal based off the placement in the list
        /// </summary>
        /// <param name="place">placement of animal in the list based off ID</param>
        /// <param name="editanimal">adds the edited values to the animal at placement</param>
        public void Edit(int place, Animal editanimal)
        {
            _animalRepo.Edit(place, editanimal);
        }



    }
}

