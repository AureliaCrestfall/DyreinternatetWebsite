using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public interface IWorkerRepo
    {

        List<Worker> GetAll();
        void Add(Worker woker);
        void Remove(int id);
    }
}
