namespace Assignment_3_1_IT1050
{
    class Program
    {
        private static object peson1;
        private static object peson2;
        private static object peson3;

        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Jake";
            person1.LastName = "Jones";
            person1.Age = 30;
            person1.Spouse = new Person();

            System.Console.WriteLine(person1.GetFullName());
            peson1.PrintNameAndAge;

            Person person2 = new Person();
            person2.FirstName = "Jet";
            person2.LastName = "Jones";
            person2.Age = 25;
            person2.Spouse = new Person();

            System.Console.WriteLine(person2.GetFullName());
            peson2.PrintNameAndAge;

            Person person3 = new Person();
            person3.FirstName = "Marlon";
            person3.LastName = "Jones";
            person3.Age = 32;
            person3.Spouse = new Person();

            System.Console.WriteLine(person3.GetFullName());
            peson3.PrintNameAndAge;

            System.Console.WriteLine("Press any key to continue..");
            System.Console.ReadKey();

        }
    }
}
