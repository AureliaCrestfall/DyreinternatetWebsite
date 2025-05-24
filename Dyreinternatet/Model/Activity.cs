namespace Dyreinternatet.Model
{
    public class Activity
    {
        /// <param>
        /// Parameter for title of the activity
        /// </param>
        string _title;
        /// <param>
        /// Parameter for content of the activity
        /// </param>
        string _content;
        /// <param>
        /// Parameter for imagepath used for the activity
        /// </param>
        string _imagePath;
        /// <param>
        /// Parameter for author of the activity
        /// </param>
        string _author;
        /// <param>
        /// Parameter for location of the activity
        /// </param>
        string _location;
        /// <param>
        /// Parameter for list of people joining the activity of the activity
        /// </param>
        List<string> _joiners;
        public  string Title
            {
            get { return _title; }
            set { _title = value; }
            }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public string imagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public List<string> joiners
        {
            get { return _joiners; }
            set { _joiners = value; }
        }

        /// <summary>
        /// default constructor used for activities
        /// </summary>
        public Activity()
        {
            _title = "test";
            _content = "nijgrniognrgoinrgnoirgniornoigrgnoi";
            _imagePath = "/Image/madcat.jpg";
            _author = "dyrinternated";
            _location = "roskilde";
            _joiners = new List<string>();
        }
        /// <summary>
        /// constructor for creating activities with the supplied values
        /// </summary>
        /// <param name="title">title of the activity</param>
        /// <param name="content">content of the activity</param>
        /// <param name="imagePath">imagepath for images for the activities</param>
        /// <param name="author">author of the activities</param>
        /// <param name="location"></param>
        public Activity(string title,string content,string imagePath,string author, string location):this()
        {
            _title = title;
            _content = content;
            _imagePath = imagePath;
            _author = author;
            _location = location;
        }



    }
}
