using System;

namespace CSharpPractice
{
    public class Animal
    {
        
        public string firstNam;
        public string Name  // property
        { get; set; }

        internal Animal(String firstName)
        {
            Name=firstName;


        }
        public void ThePrinter(string firstName = "Ponick",string lastName = "Khan", int age=0)
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
    }
}