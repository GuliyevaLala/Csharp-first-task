using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter valid number: ");
        Num: int num = Convert.ToInt32(Console.ReadLine());
            int j = 0;

            if (num == 1 || num == 0)
            {
                Console.WriteLine("Opps! Something went wrong! Try again!");
                goto Num;

            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        j++;
                    }

                }

                if (j == 2)
                {
                    Console.WriteLine("{0} is a Prime Number", num);
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                    return;
                }
                else
                {
                    Console.WriteLine("{0} is a composite", num);
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);
                    return;

                }
            }
        }

    }
}