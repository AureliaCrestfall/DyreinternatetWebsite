using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public class AnimalRepo:IAnimalRepo
    {

        List<Animal> _animals;

        protected List<Animal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }

        public List<Animal> GetAll()
        {
            return Animals;
        }

        public void Add(Animal animal)
        {
            Animals.Add(animal);
        }

        public void Remove(int chipNumber)
        {
            Animals.RemoveAt(chipNumber);
        }

        public void AddVisits(int chipNumber, string visits)
        {
            _animals[chipNumber].Visits.Add(visits);
        }


    }
}
