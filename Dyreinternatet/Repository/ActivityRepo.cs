using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public class ActivityRepo:IActivityRepo
    {
        
        List<Activity> _activities;

        protected List<Activity> Activities
        {
            get { return _activities; }
            set { _activities = value; }
        }

        public List<Activity> GetAll()
        {
            return Activities;
        }

        public void Add(Activity activity)
        {
            Activities.Add(activity);
        }

        public void Remove(int title)
        {
            Activities.RemoveAt(title); 
        }

       
    }
}
