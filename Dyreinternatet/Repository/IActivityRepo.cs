using Dyreinternatet.Model;
namespace Dyreinternatet.Repository
{
    public interface IActivityRepo
    {
        /// <summary>
        /// All the methods that need to be implemented to use this interface
        /// </summary>
        List<Activity> GetAll();
        void Add(Activity activity);
        void Remove(int title);

        void AddJoiners(int title, string joiners);
        void Edit(int title, Model.Activity editActivity);
    }
}
