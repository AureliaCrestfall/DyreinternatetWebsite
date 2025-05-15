namespace Dyreinternatet.Model
{
    public class Customer
    {
        string _name;
        string _telephone;
        string _mail;
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
    }
}
