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

            string[] names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Masen", "Mase"));


            if (String.IsNullOrWhiteSpace(null))
            {
                Console.WriteLine("Invalid");
            }

            string str = "25";
            int age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0")); 


        }
    }
}
