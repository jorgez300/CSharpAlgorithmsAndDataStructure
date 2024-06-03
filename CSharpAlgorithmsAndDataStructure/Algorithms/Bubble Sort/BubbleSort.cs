using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSharpAlgorithmsAndDataStructure.Algorithms.Bubble_Sort
{
    public class BubbleSort
    {


        public static void Execute()
        {
            List<int> IntList = new();
            int registers = 100000;

            for (int counter = 0; counter < registers; counter++)
            {
                IntList.Add(Random.Shared.Next(0, registers));
            }


            Method1(IntList);
            Method2(IntList);

        }

        //Method from book
        public static async Task Method1(List<int> IntList)
        {

            DateTime start = DateTime.Now;

            int n = IntList.Count - 1;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (IntList[j] > IntList[j + 1])
                    {
                        int temp = IntList[j];
                        IntList[j] = IntList[j + 1];
                        IntList[j + 1] = temp;
                    }
                }
            }

            IntList.ForEach((i) => { Console.Write(i.ToString() + ", "); });

            DateTime end = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine((end - start).TotalSeconds.ToString() + " Method1 Seconds");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        //Personal way
        public static async Task Method2(List<int> IntList)
        {
            DateTime start = DateTime.Now;
            int n = IntList.Count - 1;
            int x = 0;
            do
            {
                if (IntList[x] > IntList[x + 1])
                {
                    int temp = IntList[x];
                    IntList[x] = IntList[x + 1];
                    IntList[x + 1] = temp;
                    x = 0;
                }
                else
                {
                    x++;
                }

            } while (x < n);

            IntList.ForEach((i) => { Console.Write(i.ToString() + ", "); });

            DateTime end = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine((end - start).TotalSeconds.ToString() + " Method2 Seconds");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}
