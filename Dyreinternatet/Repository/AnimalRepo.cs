using Dyreinternatet.Model;
using System.Diagnostics;
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

        public void Add(Animal animals)
        {
            _animals.Add(animals);
        }

        public void Remove(int chipNumber)
        {
            _animals.RemoveAt(chipNumber);
        }

        public void AddVisits(int chipNumber, string visits)
        {
            _animals[chipNumber].Visits.Add(visits);
        }
        void seed()
        {
            _animals.Add(new Animal(0));
            _animals.Add(new Animal(1));

            _animals.Add(new Animal(2,"Buster er en kat", "Buster", "Sødmis", 5, new DateTime(2012, 12, 25, 10, 30, 50), "Buster er sød", "male", "Image\\madcat.jpg"));

        }




    }
}
