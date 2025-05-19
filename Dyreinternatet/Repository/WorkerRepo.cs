using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class WorkerRepo:IWorkerRepo
    {
        List<Worker> _workers;
        public WorkerRepo()
        {
            _workers = new List<Worker>();
        }
        //public List<Worker> Workers
        //{
        //    get { return _workers; }
        //    set { _workers = value; }
        //}

        public List<Worker> GetAll()
        {
            return _workers;
        }

        public void Add(Worker woker)
        {
            _workers.Add(woker);
        }

        public void Remove(int id)
        {
            _workers.RemoveAt(id);
        }

    }
}
