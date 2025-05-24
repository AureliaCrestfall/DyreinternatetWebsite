using System.Diagnostics;

namespace Dyreinternatet.Model
{
    public class Animal
    {
        /// <param>
        /// Parameter for chipnumber per animal
        /// </param>
        int _chipNumber;
        /// <param>
        /// Parameter for unique id per animal
        /// </param>
        int _id;
        /// <param>
        /// Parameter for species of animals
        /// </param>
        string _species;
        /// <param>
        /// Parameter for name animal
        /// </param>
        string _name;
        /// <param>
        /// Parameter for age of animal
        /// </param>
        int _age;
        /// <param>
        /// Parameter for race animal
        /// </param>
        string _race;
        /// <param>
        /// Parameter for three different genders applied to the animal
        /// </param>
        public enum Genderenum {Male,Female,Unknown};
        /// <param>
        /// Parameter for DateTime variable to apply how long the animal has been at shelter
        /// </param>
        DateTime _timeAtShelter;
        /// <param>
        /// List of parameters counting visits for the animal
        /// </param>
        List<string> _visits;
        /// <param>
        /// Parameter for the description of the animal
        /// </param>
        string _description;
        /// <param>
        /// Named the enum to be able to be utilized
        /// </param>
        Genderenum _gender;
        /// <param>
        /// Parameter for adding images to the animal
        /// </param>
        string _imgPath;
        /// <summary>
        /// Get/set for all of em
        /// </summary>
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
        /// <summary>
        /// Default constructor
        /// </summary>
        public Animal()
        {
            
            _chipNumber = 0;
            _species = "bunny";
            _name = "bunny";
            _age = 12;
            _race = "bunny";
            _timeAtShelter = DateTime.Now.Date.AddHours(DateTime.Now.Hour);
            _visits = new List<string>();
            _description = "this is a bunny";
        }
        /// <summary>
        /// Constructor for chaining default constructor with chip
        /// </summary>
        /// <param name="chip">used for applying chipnumber to animal</param>
        public Animal(int chip) : this()
        {

            _chipNumber = chip;
            _species = "bunny";
            _name = "bunny";
            _age = 12;
            _race = "bunny";
            _timeAtShelter = DateTime.Now;
            _visits = new List<string>();
            _description = "this is a bunny";
            _id = _chipNumber;

        }
        /// <summary>
        /// Constructor for creating a new animal with all included parameters
        /// </summary>
        /// <param name="chip">Chipnumber of animal</param>
        /// <param name="species">Species of animal</param>
        /// <param name="name">Name of animal</param>
        /// <param name="race">Race of animal</param>
        /// <param name="age">Age of animal</param>
        /// <param name="timeatshelter">DateTime for length of stay at shelter</param>
        /// <param name="description">Description of animal</param>
        /// <param name="gender">Gender of animal</param>
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
        /// <summary>
        /// Constructor for adding random image to animal created
        /// </summary>
        /// <param name="chip">Chipnumber of animal</param>
        /// <param name="species">Species of animal</param>
        /// <param name="name">Name of animal</param>
        /// <param name="race">Race of animal</param>
        /// <param name="age">Age of animal</param>
        /// <param name="timeatshelter">DateTime for length of stay at shelter</param>
        /// <param name="description">Description of animal</param>
        /// <param name="gender">Gender of animal</param>
        /// <param name="path">Path of the imagefile applied</param>
        public Animal(int chip, string species, string name, string race, int age, DateTime timeatshelter, string description, string gender,string path) : this( chip, species, name, race, age, timeatshelter, description,  gender)
         {
            _imgPath = path;
         }





        }



}

