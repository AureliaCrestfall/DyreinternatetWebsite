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
            Debug.WriteLine("hej"+animals.Name);


            _animals.Add(animals);
            Debug.WriteLine(_animals[3]);

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
            _animals.Add(new Animal());
            _animals.Add(new Animal());

            _animals.Add(new Animal());

        }




    }
}
