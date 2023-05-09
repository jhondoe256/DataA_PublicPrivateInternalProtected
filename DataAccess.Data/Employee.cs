namespace DataAccess.Data
{
    //Employee 'is a' Person 
    public class Employee : Person
    {
        public Employee(string firstName, string lastName, string socialSecurityNumber) : base(firstName,lastName,socialSecurityNumber)
        {

        }

        public override void MyInfo()
        {
            DisplayFullInformation();
            System.Console.WriteLine("I can also do other stuff here as well!");
            System.Console.WriteLine($"SSN: {SocialSecurityNumber}");
        }

    }
}