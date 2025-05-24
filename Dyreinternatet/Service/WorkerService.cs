using Dyreinternatet.Model;
using Dyreinternatet.Repository;

namespace Dyreinternatet.Service
{
    public class WorkerService
    {
        /// <summary>
        /// implementing the interface
        /// </summary>
        IWorkerRepo _workerRepo;
        /// <summary>
        /// default constructor for implemented interface
        /// </summary>
        /// <param name="workerRepo">name of the implemented interface</param>
        public WorkerService(IWorkerRepo workerRepo)
        {
            _workerRepo = workerRepo;
        }
        /// <summary>
        /// method for getting all content of the list Worker from repository
        /// </summary>
        /// <returns>content of the list Worker from repository</returns>
        public List<Worker> GetAll()
        {
            return _workerRepo.GetAll();
        }
        /// <summary>
        /// method for adding to the list Worker in repository
        /// </summary>
        /// <param name="woker"> name of the class that gets added</param>
        public void Add(Worker woker)
        {
            _workerRepo.Add(woker);
        }
        /// <summary>
        /// method for removing worker at specified placement in list
        /// </summary>
        /// <param name="id">specifies placement of worker</param>
        public void Remove(int id)
        {
            _workerRepo.Remove(id);
        }
        /// <summary>
        /// method for editing worker at current placement in list
        /// </summary>
        /// <param name="place">placement in list</param>
        /// <param name="editworker">values that get added at placement in list</param>
        public void Edit(int place, Worker editworker)
        {
            _workerRepo.Edit(place, editworker);
        }
    }
}
