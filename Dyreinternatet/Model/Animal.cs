using System.Diagnostics;

namespace Dyreinternatet.Model
{
    public class Animal
    {
        int _chipNumber;
        int _id;
        string _species;
        string _name;
        int _age;
        string _race;
        public  enum Genderenum {Male,Female,Unknown};
        DateTime _timeAtShelter;
        string[] _statuses;
        List<string> _visits;
        string _description;
        Genderenum _gender;
        string _imgPath;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ImgPath
        {
            get { return _imgPath; }
            set { _imgPath = value; }
        }

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
        public Genderenum Gender
        {
            get { return _gender; }
            set { _gender = value; }
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
            
            _chipNumber = 0;
            _species = "bunny";
            _name = "bunny";
            _age = 12;
            _race = "bunny";
            _timeAtShelter = DateTime.Now;
            _visits = new List<string>();
            //_statuses = new string[]();
            _description = "this is a bunny";
        }
        public Animal(int chip) : this()
        {

            _chipNumber = chip;
            _species = "bunny";
            _name = "bunny";
            _age = 12;
            _race = "bunny";
            _timeAtShelter = DateTime.Now;
            _visits = new List<string>();
            //_statuses = new string[]();
            _description = "this is a bunny";
            _id = _chipNumber;

        }

        //:this() means chaining with the before constructor animal
        public Animal(int chip, string species, string name, string race, int age, DateTime timeatshelter, string description, string gender) : this(chip)
        {


            _species = species;
            _name = name;
            _age = age;
            _race = race;
            _timeAtShelter = timeatshelter;
            gender = gender.ToLower();
            _description = description;
            if ((gender != null) && (gender.Equals("female")))
            {
                _gender = Genderenum.Female;
            }
            else if ((gender != null) && (gender.Equals("male")))
            {
                _gender = Genderenum.Male;
            }
            else
            {
                _gender = Genderenum.Unknown;

            }
        }

         public Animal(int chip, string species, string name, string race, int age, DateTime timeatshelter, string description, string gender,string path) : this( chip, species, name, race, age, timeatshelter, description,  gender)
         {
            _imgPath = path;
         }





        }



}

