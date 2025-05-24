using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public interface IWorkerRepo
    {
        /// <summary>
        /// All the methods that need to be implemented to use this interface
        /// </summary>
        List<Worker> GetAll();
        void Add(Worker woker);
        void Remove(int id);
        void Edit(int place, Worker editworker);

    }
}
