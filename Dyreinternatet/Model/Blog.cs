using System.Xml.Linq;

namespace Dyreinternatet.Model
{
    public class Blog
    {
        /// <param>
        /// title of blog
        /// </param>
        string _title;
        /// <param>
        /// content of blog
        /// </param>
        string _content;
        /// <param>
        /// imagepath used for blog
        /// </param>
        string _imagePath;
        /// <param>
        /// author of the blog
        /// </param>
        string _author;
        /// <param>
        /// id of blog for placement
        /// </param>
        int _id;

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
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// default constructor for blog
        /// </summary>
        public Blog()
        {
            _title = "dyrenes dag";
            _content = "det er dyrenes dag";
            _imagePath = "/Image/appol.jpg";
            _author = "dumbo";
        }
        /// <summary>
        /// constructor blog with supplied values
        /// </summary>
        /// <param name="title">title of the blog</param>
        /// <param name="content">content of the blog</param>
        /// <param name="imagePath">imagepath of the image for the blog</param>
        /// <param name="author">author of the blog</param>
        public Blog(string title, string content, string imagePath, string author)
        {
            _title = title;
            _content = content;
            _imagePath = imagePath;
            _author = author;
        }
    }
}
