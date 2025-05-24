using Dyreinternatet.Model;
using Dyreinternatet.Repository;

namespace Dyreinternatet.Service
{
    public class ActivityService
    {
        /// <summary>
        /// implementing the interface
        /// </summary>
        IActivityRepo _activityRepo;
        /// <summary>
        /// constructor for implementing interface
        /// </summary>
        /// <param name="activityRepo">name for using the interface</param>
        public ActivityService(IActivityRepo activityRepo)
        {
            _activityRepo = activityRepo;
        }
        /// <summary>
        /// method for adding activities to the repository
        /// </summary>
        /// <param name="activity">name of the list that gets activities added to the repository</param>
        public void Add(Activity activity)
        {
            _activityRepo.Add(activity);
        }
        /// <summary>
        /// method for removing activities from the repository
        /// </summary>
        /// <param name="title">number used for placement in the list</param>
        public void Remove(int title)
        {
            _activityRepo.Remove(title);
        }
        /// <summary>
        /// Method for getting all the activities in the list
        /// </summary>
        /// <returns>List of all acitivities in the repository</returns>
        public List<Activity> GetAll()
        {
            return _activityRepo.GetAll();
        }
        /// <summary>
        /// method for adding people that join activities
        /// </summary>
        /// <param name="title">placement of the activity in the list</param>
        /// <param name="joiners">list of people joining the activities</param>
        public void AddJoiners(int title,string joiners)
        {
            _activityRepo.AddJoiners(title, joiners);
        }
        /// <summary>
        /// method for editing activities based off the placement in the list
        /// </summary>
        /// <param name="title">placement of the activity in list</param>
        /// <param name="editactivity">values that get added to the activity being edited</param>
        public void Edit(int title, Model.Activity editactivity)
        {
            _activityRepo.Edit(title, editactivity);
        }
    }
}
