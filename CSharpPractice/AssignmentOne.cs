using System;

namespace CSharpPractice
{

    public static class AssignmentOne
    {
        private static int Gcd(int a, int b)
        {
            while (true)
            {
                if (b == 0) return a;
                var a1 = a;
                a = b;
                b = a1 % b;
            }
        }

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

        private static int Lcm(int a, int b) 
        { 
            return (a * b) / Gcd(a, b); 
        } 
        static void armstrong_number()
        {
            int num, r, sum = 0, temp;


            Console.Write("\n\n");
            Console.Write("Check whether a given number is armstrong number or not:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (temp = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum + (r * r * r);
            }

            Console.Write(sum == temp ? "{0} is an Armstrong number.\n" : "{0} is not an Armstrong number.\n", temp);
        }

        public static void Mainx()
        {
            //Perfect_Number();
            armstrong_number();
            // Console.WriteLine("GCD of " + a +" and " + b + " is " + gcd(a, b));
            // PrimeNumber();
           // FibonacciNth();
           //int a = 15, b = 20; 
           //Console.WriteLine("LCM of " + a + 
                           //  " and " + b + " is " + Lcm(a, b));
          //ReverseNumber();
       //   Factorial_N();
        }
        
        static void Factorial_N()
        {
            Console.WriteLine("\n\n Recursion : Find the factorial of a given number :");
            Console.WriteLine("-------------------------------------------------------");
	
            Console.Write(" Input any positive number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            long fact = FactorialCalcu(n1);
            Console.WriteLine(" The factorial of {0} is : {1} ", n1, fact);           
            Console.ReadKey();
        }
 
        private static long FactorialCalcu(int n1)
        {          
            if (n1 == 0)
            {
                return 1;
            }
            return n1 * FactorialCalcu(n1-1);
        }

        public static void PrimeNumber()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                Console.Write("Number is Prime.");
        }
        public static void ReverseNumber()  
        {  
            int  n, reverse=0, rem;           
            Console.Write("Enter a number: ");      
            n= int.Parse(Console.ReadLine());     
            while(n!=0)      
            {      
                rem=n%10;        
                reverse=reverse*10+rem;      
                n/=10;      
            }      
            Console.Write("Reversed Number: "+reverse);       
        }  

        public static void FibonacciNth()
        {
            int prv = 0, pre = 1, trm, i, n;

            Console.Write("\n\n");
            Console.Write("Display the first n terms of fibonacci series:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms to be display : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Here is the fibonacci series upto  to {0} terms : \n", n);
            Console.Write("{0}    {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }

        }

    }
}