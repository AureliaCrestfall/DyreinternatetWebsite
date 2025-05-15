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

        public void Add()
        {

        }

        public void Remove()
        {

        }


    }
}
