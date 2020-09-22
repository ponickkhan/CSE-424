/*Perfect number is a positive number which sum of all positive divisors excluding*/ 
/*that number is equal to that number. For example 6 is perfect number since divisor of 6 are 1, 2 and 3.*/
/*Sum of its divisor is 1 + 2+ 3 = 6*/
using System; 
namespace CSharpPractice
{
 
    public static class AssignmentOne
    {  
        public static void Main()
        {
            Console.Write("\n\n");
            Console.WriteLine("Check whether a given number is perfect number or not:");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("Enter The Number : ");
            var n = Convert.ToInt32(Console.ReadLine());
            

            var sum = 1;

                for (var i=2; i*i<=n; i++)
                {
                    if (n % i != 0) continue;
                    if(i*i!=n)
                        sum = sum + i + n/i;
                    else
                        sum=sum+i;
                }

                if (sum == n && n != 1)
                {
                    Console.WriteLine("{0} is a perfect number ! ", n);
                }
                else
                {
                    Console.WriteLine("{0} is not a perfect number ! ", n);
                }
  
                
        }  
    }

}