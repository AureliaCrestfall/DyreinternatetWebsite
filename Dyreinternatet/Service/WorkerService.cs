using Dyreinternatet.Model;
using Dyreinternatet.Repository;

namespace Dyreinternatet.Service
{
    public class WorkerService
    {

        IWorkerRepo _workerRepo;
        public WorkerService(IWorkerRepo workerRepo)
        {
            _workerRepo = workerRepo;
        }
        public List<Worker> GetAll()
        {
            return _workerRepo.GetAll();
        }
        public void Add(Worker woker)
        {
            _workerRepo.Add(woker);
        }
        public void Remove(int id)
        {
            _workerRepo.Remove(id);
        }
    }
}
