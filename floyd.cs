using System;
namespace floyd
{
    class triangle
    {
        static void Main(string[] args)
        {
            int n;
            int a=1;
            Console.WriteLine("Enter Number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nFloyds Triangle:\n");
            for (int i = 0; i < n; i++)
            {
                for(int j =0; j <= i; j++)
                {
                    Console.Write(a+" ");
                    a++;
                }
                Console.WriteLine();
            }   }   }   }
