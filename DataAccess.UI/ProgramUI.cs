using DataAccess.Data;
namespace DataAccess.UI
{
    public class ProgramUI
    {
        public void Run()
        {

            Person john = new Person("John", "Smith", "000-00-0022");
            john.ID = 3;

            john.FirstName = "Updated First Name";
            john.UpdateLastName("Updated Last Name");
            System.Console.WriteLine(john.FullName + " " + john.ID);

            System.Console.WriteLine(john.RetriveSSNumber());


            Person nullPerson = new Person();
            System.Console.WriteLine($"nullPerson: {nullPerson.FullName}.");


            Person julie = new Person("Julie", "Kenner");

            john.SayHello(julie);
            System.Console.WriteLine("============Employee=========================");

            Employee jane = new Employee("Jane", "Doe", "111-00-1111");
            System.Console.WriteLine(jane.FullName);
            jane.ID = 4;
            john.MyInfo();

            jane.MyInfo();
        }
    }
}