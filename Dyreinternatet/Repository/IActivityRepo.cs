using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public interface IActivityRepo
    {

        List<Activity> GetAll();
        void Add(Activity activity);
        void Remove(int title);

        void Edit(int place, Activity editactivity);
        void AddJoiners(int title, string joiners);

    }
}
