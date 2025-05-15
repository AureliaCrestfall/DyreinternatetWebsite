using Dyreinternatet.Model;

namespace Dyreinternatet.Repository
{
    public interface IActivityRepo
    {

        List<Activity> GetAll();
        void Add();
        void Remove();
      

    }
}
