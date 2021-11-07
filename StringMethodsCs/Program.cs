using System;

namespace StringMethodsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trim();
            string fullName = "Masen Funderburk ";
            Console.WriteLine("Trim: '{0}' ", fullName.Trim());
            //ToUpper();
            Console.WriteLine("ToUpper: '{0}' ", fullName.Trim().ToUpper());

            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);



        }
    }
}
