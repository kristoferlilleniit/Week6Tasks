using System;
using System.Linq;

namespace Week6Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            Random rnd = new Random();
            int sum = 0;

            for(int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(1, 11);
                sum += number[i];
            }

            Console.WriteLine($"The sum of the numbers is: {sum}");

            foreach(int num in number)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
