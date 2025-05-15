using Dyreinternatet.Repository;

namespace Dyreinternatet.Service
{
    public class BlogService
    {

        IActivityRepo _activityRepo;

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
    }
}
