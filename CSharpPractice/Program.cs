using System;

namespace CSharpPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            // Type your first and press enter
            Console.WriteLine("Enter your firstname:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string firstName = Console.ReadLine(); //first name
            // Type your lastname and press enter
            Console.WriteLine("Enter your lastname:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string lastName = Console.ReadLine(); //last Name
            Console.WriteLine("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine()); //last Name
            Animal Instance = new Animal();
            Instance.ThePrinter(firstName, lastName, age);



        }
    }
}
