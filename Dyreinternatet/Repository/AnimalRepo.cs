using Dyreinternatet.Model;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
namespace Dyreinternatet.Repository
{
    public class AnimalRepo:IAnimalRepo
    {

       private List<Animal> _animals;
       
        public AnimalRepo()
        {
            _animals = new List<Animal>();
            seed();
            //_animals.Add(new Animal());
        }
        //public List<Animal> Animals
        //{
        //    get { return _animals; }
        //    set { _animals = value; }
        //}

        public List<Animal> GetAll()
        {
            return _animals;
        }
        //public List<Animal> GetAllFilteredAnimals()
        //{
        //    return _filteredAnimals;
        //}

        public void Add(Animal animals)
        {
            _animals.Add(animals);
        }
        //public void AddFilteredAnimal(Animal animal)
        //{
        //    _filteredAnimals.Add(animal);
        //}

        public void Remove(int chipNumber)
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

        public void AddVisits(int chipNumber, string visits)
        {
            _animals[chipNumber].Visits.Add(visits);
        }
        void seed()
        {
            _animals.Add(new Animal(0));
            _animals.Add(new Animal(1));
            _animals.Add(new Animal(2,"kat", "Buster", "Sødmis", 5, new DateTime(2012, 12, 25, 10, 30, 50), "Buster er sød", "male", "Image\\madcat.jpg"));
            _animals.Add(new Animal(3, "hund", "Buster", "Sødmis", 5, new DateTime(2012, 12, 25, 10, 30, 50), "Buster er sød", "male", "Image\\madcat.jpg"));
            _animals.Add(new Animal(4, "kanin", "Buster", "Sødmis", 5, new DateTime(2012, 12, 25, 10, 30, 50), "Buster er sød", "male", "Image\\madcat.jpg"));
        }

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
        public List<Animal> sherch(string shearchName)
        {

            List<Animal> foundanimal = new List<Animal>();

            bool found = false;

            try
            {
                foreach (Animal animal in _animals)
                {


                    if (animal.Name.ToLower() == shearchName.ToLower())
                    {
                        Debug.WriteLine(found);
                        foundanimal.Add(animal);
                        found = true;
                    }
                    else
                    {
                        Debug.WriteLine("chach test");

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
            catch(NullReferenceException ex)
            {
                throw new Exception("sherch keuy is empty");
            }

        }



        public void Edit(int place, Animal editanimal)
        {
            editanimal.ImgPath = _animals[place].ImgPath;
            editanimal.TimeAtShelter = _animals[place].TimeAtShelter;
            _animals[place] = editanimal;
        }

        public List<Animal> Sort(List<Animal> bubble)
        {

            bool swapped = true;
            int n = 0;
            foreach (Animal animal in bubble)
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
            for (int i = 0; i < n; i++)
            {
                bubble[i].ID = i;
            }

            return bubble;
        }


    }
}
