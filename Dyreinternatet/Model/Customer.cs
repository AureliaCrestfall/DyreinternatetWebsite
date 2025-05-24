namespace Dyreinternatet.Model
{
    public class Customer
    {
        /// <param>
        /// Parameter for name of customer
        /// </param>
        string _name;
        /// <param>
        /// Parameter for telephone number of customer
        /// </param>
        string _telephone;
        /// <param>
        /// Parameter for the email of customer
        /// </param>
        string _mail;
        /// <param>
        /// Parameter for adress of customer
        /// </param>
        string _adress;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        /// <summary>
        /// default constructor for customer
        /// </summary>
        public Customer()
        {
            _name = "Dumbo";
            _telephone = "123456";
            _mail = "dumbo@dumbo.com";
            _adress = "Internat";
        }
        /// <summary>
        /// constructor used for creating a customer with supplied parameters
        /// </summary>
        /// <param name="name">name of customer</param>
        /// <param name="telephone">telephone number of costumer</param>
        /// <param name="mail">email of costumer</param>
        /// <param name="adress">adress of costumer</param>
        public Customer(string name, string telephone, string mail, string adress)
        {
            _name = name;
            _telephone = telephone;
            _mail = mail;
            _adress = adress;
        }
    }
}
