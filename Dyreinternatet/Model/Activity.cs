namespace Dyreinternatet.Model
{
    public class Activity
    {
        string _title;
        string _content;
        string _imagePath;
        string _author;
        string _location;
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

        public Activity()
        {
            _title = "test";
            _content = "nijgrniognrgoinrgnoirgniornoigrgnoi";
            _imagePath = "/image0.jpg";
            _author = "dyrinternated";
            _location = "roskilde";

        }
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
