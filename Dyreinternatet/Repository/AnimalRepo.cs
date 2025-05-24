using Dyreinternatet.Model;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
namespace Dyreinternatet.Repository
{
    public class AnimalRepo:IAnimalRepo
    {
        /// <summary>
        /// Instancing list of animal class named _animals
        /// </summary>
       private List<Animal> _animals;
       
        /// <summary>
        /// Default constructor using seed method
        /// </summary>
        public AnimalRepo()
        {
            _animals = new List<Animal>();
            seed();
        }
        
        /// <summary>
        /// Method that gets all in the list Animal
        /// </summary>
        /// <returns>list _animals </returns>
        public List<Animal> GetAll()
        {
            return _animals;
        }

        /// <summary>
        /// Method for adding animals to the list _animals
        /// </summary>
        /// <param name="animals">name of the class that gets added to the list _animals</param>
        public void Add(Animal animals)
        {
            _animals.Add(animals);
        }
        
        /// <summary>
        /// method that removes animal from the list at the chipnumber specified and moves other animals to their new ID
        /// </summary>
        /// <param name="chipNumber">ID of animal that shows place in list</param>
        /// <exception cref="ArgumentOutOfRangeException">When trying to remove non-existing animal, sends error message</exception>
        public void Remove(int chipNumber)
        {
            try
            {
               
                _animals.RemoveAt(chipNumber);
                int n = 0;

                foreach (Animal animal in _animals)
                {
                    n++;
                }


            for (int i = 0;i< n; i++)
                {
                    _animals[i].ID = i;
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new ArgumentOutOfRangeException(ex.Message);
            }
        }
        /// <summary>
        /// Method to add visits to the animal at specified chipnumber
        /// </summary>
        /// <param name="chipNumber">ID of animal in list that shows placement in list</param>
        /// <param name="visits">parameter of string that gets added to the list of visitis</param>
        public void AddVisits(int chipNumber, string visits)
        {
            _animals[chipNumber].Visits.Add(visits);
        }
        /// <summary>
        /// Method for adding animals to the list, default and specified animals
        /// </summary>
        void seed()
        {
            _animals.Add(new Animal(0));
            _animals.Add(new Animal(1));
            _animals.Add(new Animal(2,"kat", "Buster", "Sødmis", 5, new DateTime(2012, 12, 25, 10, 30, 50), "Buster er sød", "male", "Image\\madcat.jpg"));
            _animals.Add(new Animal(3, "hund", "Buster", "Sødmis", 5, new DateTime(2012, 12, 25, 10, 30, 50), "Buster er sød", "male", "Image\\madcat.jpg"));
            _animals.Add(new Animal(4, "kanin", "Buster", "Sødmis", 5, new DateTime(2012, 12, 25, 10, 30, 50), "Buster er sød", "male", "Image\\madcat.jpg"));
        }
        /// <summary>
        /// Method for filtering in list to only show animals based off gender or species parameter
        /// </summary>
        /// <param name="species">species of animal</param>
        /// <param name="gender">unused</param>
        /// <returns>filtered list of animals that fit the specific species applied</returns>
        public List<Animal> Filter(string species, string gender)
        {
             List<Animal> _filteredAnimals = new List<Animal>();
           

            if (species == "hund")
            {
                foreach (Animal animal in _animals)
                {
                    if (animal.Species == "hund")
                    {
                        _filteredAnimals.Add(animal);
                    }
                }
            }
            else if (species == "kanin")
            {
                foreach (Animal animal in _animals)
                {
                    if (animal.Species == "kanin")
                    {
                        _filteredAnimals.Add(animal);
                    }
                }
            }
            else if (species == "kat")
            {
                foreach (Animal animal in _animals)
                {
                    if (animal.Species== "kat")
                    {
                        _filteredAnimals.Add(animal);
                    }
                }
            }
            else if (species == "hundkat")
            {
                foreach (Animal animal in _animals)
                {
                    if (animal.Species.ToLower() == "kat")
                    {
                        _filteredAnimals.Add(animal);
                    }
                    if (animal.Species.ToLower() == "hund")
                    {
                        _filteredAnimals.Add(animal);
                    }
                }
            }
            else if (species == "katkanin")
            {
                foreach (Animal animal in _animals)
                {
                    if (animal.Species.ToLower() == "kat" )
                    {
                        _filteredAnimals.Add(animal);
                    }
                    if (animal.Species.ToLower() == "kanin")
                    {
                        _filteredAnimals.Add(animal);
                    }
                }
            }
            else if (species == "hundkanin")
            {
                foreach (Animal animal in _animals)
                {
                    if (animal.Species.ToLower() == "kanin")
                    {
                        _filteredAnimals.Add(animal);
                    }
                    if (animal.Species.ToLower() == "hund")
                    {
                        _filteredAnimals.Add(animal);
                    }
                }
            }
            else if (species == "hundkatkanin")
            {
                foreach (Animal animal in _animals)
                {
                    if (animal.Species.ToLower() == "kanin")
                    {
                        _filteredAnimals.Add(animal);
                    }
                    if (animal.Species.ToLower() == "hund")
                    {
                        _filteredAnimals.Add(animal);
                    }
                    if (animal.Species.ToLower() == "kat")
                    {
                        _filteredAnimals.Add(animal);
                    }
                }
            }


            return _filteredAnimals;
        }
        /// <summary>
        /// Method for searching in the list of Animal
        /// </summary>
        /// <param name="shearchName">Used for searching from the name of animals</param>
        /// <returns>List of animals that fit the search term</returns>
        public List<Animal> sherch(string shearchName)
        {

            List<Animal> foundanimal = new List<Animal>();

            bool found = false;
         

            if(shearchName == null)
            {
                shearchName = "";
            }
                
                foreach (Animal animal in _animals)
                {


                    if (animal.Name.ToLower() == shearchName.ToLower())
                    {
                        foundanimal.Add(animal);
                        found = true;
                    }
                   




                }

                if (found == true)
                {
                    return foundanimal;

                }
                else
                {
                    return _animals;

                }
            

        }


        /// <summary>
        /// Method for editing animal at place in list
        /// </summary>
        /// <param name="place">placement of animal based off ID</param>
        /// <param name="editanimal">Contains the new info of the edit</param>
        public void Edit(int place, Animal editanimal)
        {
            editanimal.ImgPath = _animals[place].ImgPath;
            editanimal.TimeAtShelter = _animals[place].TimeAtShelter;
            _animals[place] = editanimal;
        }
        /// <summary>
        /// Sorts the animal list based off age
        /// </summary>
        /// <returns>sorted list of animals from youngest to oldest</returns>
        public List<Animal> Sort()
        {
            List<Animal> sortList = new List<Animal>(_animals);
            bool swapped = true;
            int n = 0;
            foreach (Animal animal in sortList)
            {
                n++;
            }
            while (swapped != false)
            {

                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (sortList[i].Age > sortList[i + 1].Age)
                    {
                        (sortList[i], sortList[i + 1]) = (sortList[i + 1], sortList[i]);

                        swapped = true;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                sortList[i].ID = i;
            }

            return sortList;
        }


    }
}
