namespace Dyreinternatet.Model
{
    public class Animal
    {
        int _chipNumber;
        string _species;
        string _name;
        int _age;
        string _race;
        enum _enum;
        DateTime _timeAtShelter;
        string[] _statuses;
        List<string> _visits;
        string _description;

        public int ChipNumber
        {
            get { return _chipNumber; }
            set { _chipNumber = value; }
        }
        public string Species
        {
            get {return _species; }
            set { _species = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string race
        {
            get {return _race; }
            set { _race = value; }

        }
        public enum Gender
        {
            
        }
        public DateTime TimeAtShelter
        {
            get { return _timeAtShelter; }
            set {
                _timeAtShelter = value;}
        }
        public string[] Statuses
        {
            get { return _statuses; }
            set { _statuses = value; }
        }
        public List<string> Visits
        {
            get { return _visits; }
            set { _visits = value; }
        }
        public string Description
        {
            get {return _description; }
            set { _description = value; }
        }

        public Animal()
        {

            _chipNumber = _chipNumber++;
            _species = "bunny";
            _name = "bunny";
            _age = 12;
            _race = "bunny";
            _timeAtShelter = DateTime.Now;
            _visits = new List<string>();
            //_statuses = new string[]();
            _description = "this is a bunny";

        }
        public Animal(string species,string name,string race,int age,DateTime timeatshelter,string descripn):this()
        {

           
            _species = species;
            _name = name;
            _age = age;
            _race = race;
            _timeAtShelter = timeatshelter;
           
            _description = descripn;

        }



    }
}
