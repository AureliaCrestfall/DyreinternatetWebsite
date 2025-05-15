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

        public void Add(Worker woker)
        {
            Workers.Add(woker);
        }

        public void Remove(int id)
        {
            Workers.RemoveAt(id);
        }

    }
}
