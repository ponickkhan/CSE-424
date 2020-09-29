using System;

namespace CSharpPractice
{
 
    public static class AssignmentOne
    {

        static int gcd(int a, int b)
        {      
            if (b == 0)
                return a;
            return gcd(b, a % b); 
        }
        public static void Perfect_Number()
        {
            Console.Write("\n\n");
            Console.WriteLine("Check whether a given number is perfect number or not:");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("Enter The Number : ");
            Int64 n = Convert.ToInt64(Console.ReadLine());

            var sum = 1;

            for (var i=2; i*i<=n; i++)
            {
                if (i>0)
                    if (n % i != 0) continue;
                if (i*i!=n)
                {
                    sum = (int) (sum + i + n / i);
                } else
                    sum=sum+i;
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

        static void armstrong_number()
        {
            int num,r,sum=0,temp;
	
	
            Console.Write("\n\n");
            Console.Write("Check whether a given number is armstrong number or not:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");  	

            Console.Write("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());	
            for(temp=num;num!=0;num=num/10){
                r=num % 10;
                sum=sum+(r*r*r);
            }

            Console.Write(sum == temp ? "{0} is an Armstrong number.\n" : "{0} is not an Armstrong number.\n", temp);
        }

        public static void Mainx()
        {
            //Perfect_Number();
            //armstrong_number();
            // int a = 98, b = 56;
            // Console.WriteLine("GCD of " + a +" and " + b + " is " + gcd(a, b));
            primeNumber();
        }

        public static void primeNumber()
        {
            int n, i, m=0, flag=0;    
            Console.Write("Enter the Number to check Prime: ");    
            n = int.Parse(Console.ReadLine());  
            m=n/2;    
            for(i = 2; i <= m; i++)    
            {    
                if(n % i == 0)    
                {    
                    Console.Write("Number is not Prime.");    
                    flag=1;    
                    break;    
                }    
            }    
            if (flag==0)    
                Console.Write("Number is Prime.");       
        }
    }

}