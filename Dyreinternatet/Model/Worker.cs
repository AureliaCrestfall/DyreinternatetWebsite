namespace Dyreinternatet.Model
{
    public class Worker
    {
        string _name;
        int _id;
        string _mail;
        string _telephone;
        string _jobTitle;

        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        { 
            get { return _id;}
            set { _id = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }
    }
}
