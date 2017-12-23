using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            Random rand = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                ints.Add(rand.Next(1,11));
            }
            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");
            BubbleSort(ints);
            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
        static void BubbleSort(List<int> numbers)
        {
            bool Swapping;
            do
            {

                Swapping = false;
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        Swapping = true;
                        int temp;
                        temp = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = temp;

                    }
                }
            } while (Swapping);
        }
    }
}
