namespace Dyreinternatet.Model
{
    public class Worker
    {
        /// <param>
        /// Parameter for name of worker
        /// </param>
        string _name;
        /// <param>
        /// Parameter for ID of worker
        /// </param>
        int _id;
        /// <param>
        /// Parameter for email of worker
        /// </param>
        string _mail;
        /// <param>
        /// Parameter for telephone number of worker
        /// </param>
        string _telephone;
        /// <param>
        /// Parameter for jobtitle of worker
        /// </param>
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
        /// <summary>
        /// default constructor 
        /// </summary>
        public Worker()
        {
            _name = "Dumbo";
            _id = 0;
            _telephone = "123456";
            _mail = "dumbo@dumbo.com";
            _jobTitle = "Frivillig";
        }
        /// <summary>
        /// Constructor for creating a new worker with supplied values
        /// </summary>
        /// <param name="name">name of worker</param>
        /// <param name="id">id of worker</param>
        /// <param name="telephone">telephone number of worker</param>
        /// <param name="mail">email of worker</param>
        /// <param name="jobTitle">job title of worker</param>
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
