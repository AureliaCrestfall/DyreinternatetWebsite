using Dyreinternatet.Model;
using Dyreinternatet.Repository;

namespace Dyreinternatet.Service
{
    public class ActivityService
    {

        IActivityRepo _activityRepo;
        public ActivityService(IActivityRepo activityRepo)
        {
            _activityRepo = activityRepo;
        }

        public void Add(Activity activity)
        {
            _activityRepo.Add(activity);
        }
        public void Remove(int title)
        {
            _activityRepo.Remove(title);
        }
        public List<Activity> GetAll()
        {
            return _activityRepo.GetAll();
        }
        public void AddJoiners(int title,string joiners)
        {
            _activityRepo.AddJoiners(title, joiners);
        }

        public void Edit(int title, Activity editactivity)
        {
            _activityRepo.Edit(title, editactivity);
        }
    }
}
