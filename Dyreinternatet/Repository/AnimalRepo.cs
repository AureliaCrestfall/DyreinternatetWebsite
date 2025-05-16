using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public class AnimalRepo:IAnimalRepo
    {

        List<Animal> _animals;

        //public List<Animal> Animals
        //{
        //    get { return _animals; }
        //    set { _animals = value; }
        //}

        public List<Animal> GetAll()
        {
            return _animals;
        }

        public void Add(Animal animal)
        {
            _animals.Add(animal);
        }

        public void Remove(int chipNumber)
        {
            _animals.RemoveAt(chipNumber);
        }

        public void AddVisits(int chipNumber, string visits)
        {
            _animals[chipNumber].Visits.Add(visits);
        }

        
        public AnimalRepo()
        {
            _animals = new List<Animal>();
            _animals.Add(new Animal());
        }

    }
}
