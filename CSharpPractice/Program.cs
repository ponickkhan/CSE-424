using System;

namespace CSharpPractice
{
    class Program
    {

        static void ThePrinter(string firstName = "Ponick",string lastName = "Khan", int age=0)
        {
            

            string fullName = firstName + " " + lastName;
            Console.WriteLine("Your Full Name:");
            Console.WriteLine(fullName);
            Console.WriteLine("Your Age:");
            TheAger(age);


        }
        
        static void TheAger(int age)
        {
            
            Console.WriteLine(age);
            
        }
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

            ThePrinter(firstName, lastName, age);



        }
    }
}
