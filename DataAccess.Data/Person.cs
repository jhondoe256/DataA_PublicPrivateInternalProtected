namespace DataAccess.Data
{
    //public => Any Referencing Layer can access this Person object
    //private => Any Person Properties, Methods can only be accessed within the Person Obj (if marked private)
    //           in certian instances you can "Construct" private data, but then you can not modify them.
    //internal => Any Person obj can only live in the data layer
    //Protected => This has to do with inheriting members
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        protected string SocialSecurityNumber { get; set; } = string.Empty;

        public string FullName
        {
            get
            {
                return $"{FirstName} - {LastName}";
            }
        }

        public string GiveMeLastName()
        {
            return LastName;
        }

        public string RetriveSSNumber()
        {
            //check if the user has an ssNumber
            if (SocialSecurityNumber != null)
            {
                return SocialSecurityNumber;
            }
            else
            {
                return "Not found.";
            }
        }

        public void SayHello(Person person)
        {
            Helper.Greet(person);
        }

        //this is basically making the LastName property Public
        public void UpdateLastName(string lastName)
        {
            LastName = lastName;
        }

        protected void DisplayFullInformation()
        {
            System.Console.WriteLine($"Id: {ID}\n" +
                                     $"Name: {FullName}\n" +
                                     "--------------------------\n");
        }

        //this will allow me to "Change this method w/n Inheriting members"
        public virtual void MyInfo()
        {
            DisplayFullInformation();
        }
    }
}