using System.Xml.Linq;

namespace Dyreinternatet.Model
{
    public class Blog
    {
        string _title;
        string _content;
        string _imagePath;
        string _author;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
    }
}
