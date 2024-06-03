using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithmsAndDataStructure.Algorithms.Counting_Sort
{
    public class CountingSort
    {
        public static void Execute()
        {
            List<int> IntList = new();
            int registers = 10;
            int maxRange = 5;

            for (int counter = 0; counter < registers; counter++)
            {
                IntList.Add(Random.Shared.Next(1, maxRange + 1));
            }


            Method1(IntList, maxRange);

        }

        public static async Task Method1(List<int> IntList, int maxRange)
        {

            DateTime start = DateTime.Now;


            int[] ints = new int[maxRange];

            IntList.ForEach((i) =>
            {
                ints[i - 1] = ints[i - 1] + 1;
            });

            IntList.ForEach((i) => { Console.Write(i.ToString() + ", "); });
            Console.WriteLine();
            for (int counter = 0; counter < maxRange; counter++)
            {
                Console.WriteLine((counter + 1).ToString() + ": " + ints[counter].ToString());
            }


            DateTime end = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine((end - start).TotalSeconds.ToString() + " Method1 Seconds");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
