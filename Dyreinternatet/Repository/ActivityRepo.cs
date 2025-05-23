using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public class ActivityRepo : IActivityRepo
    {
        
        List<Activity> _activities;

        public ActivityRepo()
        {
            _activities = new List<Activity>();
            _activities.Add(new Activity());
        }
        //protected List<Activity> Activities
        //{
        //    get { return _activities; }
        //    set { _activities = value; }
        //}

        public List<Activity> GetAll()
        {
            return _activities;
        }

        public void Add(Activity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(int title)
        {
            _activities.RemoveAt(title); 
        }
        public void AddJoiners(int title, string joiners)
        {
            _activities[title].joiners.Add(joiners);
        }
        public void Edit(int title, Model.Activity editactivity)
        {
            editactivity = _activities[title];
            _activities[title] = editactivity;
            
        }
    }
}
