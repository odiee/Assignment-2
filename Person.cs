using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_1_IT1050
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static double SumofAllAges { get; private set; }
        public static double Count { get; private set; }

        public string GetFullName()
        {
          return FirstName + "" + LastName; // For some reason it keeps telling me to use Person.LastName.

        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.FirstName + " ", LastName + " ", Age);

        }

        public static double AverageAge()
        {
            return (double)Person.SumofAllAges / (double)Person.Count;
    }

}
