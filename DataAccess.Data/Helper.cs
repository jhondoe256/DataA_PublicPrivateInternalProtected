namespace DataAccess.Data
{
    internal static class Helper
    {
        public static void Greet(Person person)
        {
            System.Console.WriteLine($"Hello, {person.FirstName}!");
        }
    }
}