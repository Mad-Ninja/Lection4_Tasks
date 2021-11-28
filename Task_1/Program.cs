using System;
using System.Linq;
namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rand = new Random();

            for(int i = 0;i< numbers.Length; i++)
            {
                numbers[i] = rand.Next(99);
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine("Sort:");

            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }



            //or

            numbers = numbers.OrderBy(x => x).ToArray();
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }




        }
    }
}
