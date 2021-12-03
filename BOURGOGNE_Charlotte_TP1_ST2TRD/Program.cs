using System;

namespace BOURGOGNE_Charlotte_TP1_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Exercise1_1();
            Exercise1_2();
            Exercise1_3();

            Prime();
            F();
            Factorial();

            try_catch();

            Square();
            
            Tree();
        }

        private static void Exercise1_1()
        {
            Console.Write("\n\n");  
            Console.Write("---------------------------------------------------\n");
            Console.WriteLine("Multiplication tables from 1*1 to 10*10 :");
            Console.Write("\n"); 
            
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    Console.WriteLine($"{a}*{b}={a * b}");
                }
            }
        }
        
        private static void Exercise1_2()
        {
            Console.Write("\n\n");  
            Console.Write("---------------------------------------------------\n");
            Console.WriteLine("Print only the odd result :");
            Console.Write("\n");  
            
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    if ((a * b) % 2 != 0)
                    {
                        Console.WriteLine($"{a}*{b}={a * b}");
                    }
                }
            }
        }
        
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        private static void Exercise1_3()
        {
            Console.Write("\n\n");
            Console.Write("---------------------------------------------------\n");
            Console.Write("Multiplication table for this number N :");
            Console.Write("\n");  
            int a = AskUserForParameter();
            
            while (a < 1)
            {
                a = AskUserForParameter();
            }
            for (int b = 1; b <= 10; b++)
            {
                Console.WriteLine($"{a}*{b}={a * b}");
            }
        }
        
        private static void Prime()
        {
            Console.Write("\n\n");
            Console.Write("---------------------------------------------------\n");
            Console.Write("Print the prime numbers between 1 to 1000 :");
            Console.Write("\n");  
      
            int i, p, k;
            for (i = 1; i <= 1000; i++)
            {
                k = 2;
                p = 1;
                while (k < i)
                {
                    if (i % k == 0)
                    {
                        p = 0;
                        break;
                    }
                    k++;
                }
                if (p == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static int AskUserFibo()
        {
            var size = 0;
            while (size < 2)
            {
                Console.WriteLine("Please enter a size >= 2 :");
                int.TryParse(Console.ReadLine(), out size);
            }
            return size;
        }
        private static void F()
        {
            Console.Write("\n\n"); 
            Console.Write("---------------------------------------------------\n");
            Console.Write("The Fibonacci Series : ");
            Console.Write("\n");  
            
            int length = AskUserFibo();
            for (int i = 0; i < length; i++)
            {
                Console.Write(" {0} ", Fibo(i));
            }
        }
        private static int Fibo(int n)  
        {  
            if (n == 0) return 1; 
            if (n == 1) return 1;   
            return Fibo(n - 1) + Fibo(n - 2);  
        }

        private static int AskUserFacto()
        {
            var number = 0;
            while (number < 1)
            {
                Console.WriteLine("Please write a number and press enter :");
                int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
        private static void Factorial()
        {
            Console.Write("\n\n"); 
            Console.Write("---------------------------------------------------\n");
            Console.Write("The Factorial : ");
            Console.Write("\n");  
            
            int number = AskUserFacto();
            double facto = Facto(number);
            Console.WriteLine("Factorial of "+number+" = "+facto); 
            Console.Write("\n"); 
            Console.Write("A recursive function is a function that calls itself directly or indirectly.");
        }
        private static double Facto(int number)    
        {    
            if (number == 0) return 1;    
            return number * Facto(number-1);
        }

        private static void try_catch()
        {
            Console.Write("\n\n"); 
            Console.Write("---------------------------------------------------\n");
            Console.Write("Try/Catch Block : ");
            Console.Write("\n"); 
            
            for (int i = -3; i <= 3; i++)
            {
                Console.WriteLine(PowerFunction(i));
            }
        }

        private static int PowerFunction(int x)
        {
            int result = 0;
            if (x <= 3 && x >= -3)
            {
                try
                {
                    result = 10/(int)(Math.Pow(x, 2) - 4);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }

        private static int AskUserSquare()
        {
            var size = 0;
            while (size < 1 || size > 1000 )
            {
                Console.WriteLine("Please enter a size between 1 and 1000:");
                int.TryParse(Console.ReadLine(), out size);
            }
            return size;
        }
        private static void Square()
        {
            Console.Write("\n\n"); 
            Console.Write("---------------------------------------------------\n");
            Console.Write("Square : ");
            Console.Write("\n"); 
            
            int i, j;
            int n = AskUserSquare();
            int m = AskUserSquare();
            
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if((i==1 && j==1) || (i==1 && j==n) || (i==m && j==1) || (i==m && j==n))
                    {
                        Console.Write("0"); 
                    }
                    else if((i==1 && ((j!=1) && (j!=n)))|| (i==m && ((j!=1) && (j!=n))))
                    {
                        Console.Write("-"); 
                    }
                    else if((j==1 && ((i!=1) && (i!=m)))|| (j==n && ((i!=1) && (i!=m))))
                    {
                        Console.Write("|"); 
                    }
                    else if ((i==j) || (j == (i + 3)) || (i == (j + 3)))
                    {
                        Console.Write("*");
                    }
                    else       
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static int AskUserTree()
        {
            var size = 0;
            while (size < 3 || size > 20 )
            {
                Console.WriteLine("Please enter a size between 3 and 20:");
                int.TryParse(Console.ReadLine(), out size);
            }
            return size;
        }
        private static void Tree()
        {
            Console.Write("\n\n"); 
            Console.Write("---------------------------------------------------\n");
            Console.Write("Christmas Tree : ");
            Console.Write("\n"); 
            
            int n = AskUserTree();
            string s = "*".PadLeft(n);
            Console.WriteLine(s);
            
            for (int i = 1; i < n; i++)
            {
                s = s.Substring(1) + "**";
                Console.WriteLine(s);
            }
            string t = "| |".PadLeft(n+1);
            Console.WriteLine(t);
        }
    }
}