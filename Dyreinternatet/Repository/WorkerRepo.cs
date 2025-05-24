using System.Xml.Linq;
using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public class WorkerRepo:IWorkerRepo
    {
        /// <summary>
        /// instancing the list _workers
        /// </summary>
        List<Worker> _workers;
        /// <summary>
        /// default constructor
        /// </summary>
        public WorkerRepo()
        {
            _workers = new List<Worker>();
            seed();
        }
        
        /// <summary>
        /// gets all the values in list Worker
        /// </summary>
        /// <returns>list _workers</returns>
        public List<Worker> GetAll()
        {
            return _workers;
        }
        /// <summary>
        /// adds worker to the list of Worker
        /// </summary>
        /// <param name="woker">name of the class that gets added to the list _workers</param>
        public void Add(Worker woker)
        {
            _workers.Add(woker);
        }
        /// <summary>
        /// removes from list _workers at specificed placement 
        /// </summary>
        /// <param name="id">id given to _workers to specify placement in list</param>
        public void Remove(int id)
        {
            _workers.RemoveAt(id);
        }
        /// <summary>
        /// Method for adding workers to the list, default and specified workers
        /// </summary>
        void seed()
        {
            _workers.Add(new Worker("John Doe", 0, "123456", "johndoe@gmail.com", "Dyrlæge"));
            _workers.Add(new Worker("Kim Kardashian", 2, "123456", "KimK@gmail.com", "Frivillig"));
        }
        /// <summary>
        /// Method for editing workers at current placement
        /// </summary>
        /// <param name="place">placemen of worker in list</param>
        /// <param name="editworker">values that gets added to the specified placement in list</param>
        public void Edit(int place, Worker editworker)
        {
            _workers[place] = editworker;
        }
    }
}
