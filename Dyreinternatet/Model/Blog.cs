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
        public Blog()
        {
            _title = "dyrenes dag";
            _content = "det er dyrenes dag";
            _imagePath = "c/images";
            _author = "dumbo";
        }
        public Blog(string title, string content, string imagePath, string author)
        {
            _title = title;
            _content = content;
            _imagePath = imagePath;
            _author = author;
        }
    }
}
