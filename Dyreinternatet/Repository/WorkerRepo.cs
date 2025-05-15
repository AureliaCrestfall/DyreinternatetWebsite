using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class WorkerRepo:IWorkerRepo
    {

        List<Worker> _workers;

        protected List<Worker> Workers
        {
            get { return _workers; }
            set { _workers = value; }
        }

        public List<Worker> GetAll()
        {
            return Workers;
        }

        public void Add()
        {

        }

        public void Remove()
        {

        }

    }
}
