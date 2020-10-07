using System;

namespace Week6Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[11];
            Random rnd = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(1, 11);
            }
            int smallest = number[0];
            for(int i = 0; i < 10; i++)
            {
                if(number[i] < smallest)
                {
                    smallest = number[i];
                }
            }
            int largest = number[10];
            for(int i=0; i < 10; i++)
            {
                if(number[i] > largest)
                {
                    largest = number[i];
                }
            }

            Console.WriteLine($"Smallest number is: {smallest}");
            Console.WriteLine($"Largest number is: {largest}");


            foreach (int num in number)
            {
                Console.WriteLine(num);
            }
            

        }
    }
}
