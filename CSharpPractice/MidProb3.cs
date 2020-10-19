using System;

namespace CSharpPractice
{
    public class MidProb3
    {
        public static void Perfect_Number()
        {
            Console.Write("\n\n");
            Console.WriteLine("Check whether a given number is perfect number or not:");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("Enter The Number : ");
            Int64 n = Convert.ToInt64(Console.ReadLine());

            var sum = 1;

            for (var i = 2; i * i <= n; i++)
            {
                if (i > 0)
                    if (n % i != 0)
                        continue;
                if (i * i != n)
                {
                    sum = (int) (sum + i + n / i);
                }
                else
                    sum = sum + i;
            }

            if (sum == n && n != 1)
            {
                Console.WriteLine($"{n} is a perfect number ! ");
            }
            else
            {
                Console.WriteLine($"{n} is not a perfect number ! ");
            }



        }

        public static void Mainx()
        {
            Perfect_Number();

        }
    }
}