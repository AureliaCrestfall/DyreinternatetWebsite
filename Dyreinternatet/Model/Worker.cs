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
        public Worker()
        {
            _name = "Dumbo";
            _id = 0;
            _telephone = "123456";
            _mail = "dumbo@dumbo.com";
            _jobTitle = "Frivillig";
        }
        public Worker(string name, int id, string telephone, string mail, string jobTitle)
        {
            _name = name;
            _id = id;
            _telephone = telephone;
            _mail = mail;
            _jobTitle = jobTitle;
        }
    }
}
