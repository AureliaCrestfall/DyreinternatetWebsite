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

        public void Add()
        {

        }

        public void Remove()
        {

        }

       
    }
}
