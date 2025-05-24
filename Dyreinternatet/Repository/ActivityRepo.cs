using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public class ActivityRepo : IActivityRepo
    {
        /// <summary>
        /// instancing the list of activities
        /// </summary>
        List<Activity> _activities;

        /// <summary>
        /// default constructor for adding to repo
        /// </summary>
        public ActivityRepo()
        {
            _activities = new List<Activity>();
            _activities.Add(new Activity());
        }

        /// <summary>
        /// method for getting all activities in list Activity
        /// </summary>
        /// <returns>list _activities</returns>
        public List<Activity> GetAll()
        {
            return _activities;
        }
        /// <summary>
        /// Method for adding new activities to the list
        /// </summary>
        /// <param name="activity">name of the class that gets added to the list _activities</param>
        public void Add(Activity activity)
        {
            _activities.Add(activity);
        }
        /// <summary>
        /// removes activity from the list based off the ID it gets from title
        /// </summary>
        /// <param name="title">adds an id in the form of title for placement in the list</param>
        public void Remove(int title)
        {
            _activities.RemoveAt(title); 
        }
        /// <summary>
        /// Method for adding people that join the activities
        /// </summary>
        /// <param name="title">placement of the activity</param>
        /// <param name="joiners">name of people joining</param>
        public void AddJoiners(int title, string joiners)
        {
            _activities[title].joiners.Add(joiners);
        }
        /// <summary>
        /// Edits activities based off placement in list
        /// </summary>
        /// <param name="title">placement in list</param>
        /// <param name="editactivity">the new values added to the edited activity</param>
        public void Edit(int title, Model.Activity editactivity)
        {
            editactivity = _activities[title];
            _activities[title] = editactivity;
            
        }
    }
}
