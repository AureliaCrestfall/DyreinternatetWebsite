using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class WorkerRepo:IWorkerRepo
    {
        IWorkerRepo _workerRepo;
        List<Worker> _workers;
        public WorkerRepo(IWorkerRepo workerRepo)
        {
            _workerRepo = workerRepo;
        }

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
            _workerRepo.Add(woker);
        }

        public void Remove(int id)
        {
            Workers.RemoveAt(id);
        }

    }
}
