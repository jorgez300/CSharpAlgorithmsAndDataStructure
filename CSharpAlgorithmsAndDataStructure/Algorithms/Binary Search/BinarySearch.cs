using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithmsAndDataStructure.Algorithms.Binary_Search
{
    public class BinarySearch
    {

        public static void Execute()
        {

            List<int> IntList = new() {
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30
            };

            int SearchValue = 15;
            Console.WriteLine("SearchValue: " + SearchValue);
            Console.WriteLine();
            Console.WriteLine();

            int startIndex = 0;
            int endIndex = IntList.Count - 1;

            Method1(IntList, SearchValue, startIndex, endIndex);

        }

        public static void Method1(List<int> IntList, int SearchValue, int startIndex, int endIndex)
        {

            int MidIndex = ((endIndex - startIndex) / 2) + startIndex;

            var x = IntList[MidIndex];

            Console.WriteLine("Mid Index: " + MidIndex);
            Console.WriteLine("End Index: " + endIndex);
            Console.WriteLine("Start Index: " + startIndex);
            for (int i = startIndex; i < endIndex; i++)
            {
                Console.Write(IntList[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            if (IntList[startIndex] > SearchValue || IntList[endIndex] < SearchValue)
            {
                Console.WriteLine("Not Found");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if ((endIndex - startIndex) == 1)
            {

                if (IntList[endIndex] == SearchValue)
                {
                    Console.WriteLine("Index: " + endIndex);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (IntList[startIndex] == SearchValue)
                {
                    Console.WriteLine("Index: " + startIndex);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Not Found");
                    Console.WriteLine();
                    Console.WriteLine();
                }

            }
            else if (IntList[MidIndex] > SearchValue)
            {
                endIndex = MidIndex;
                Method1(IntList, SearchValue, startIndex, endIndex);
            }
            else if (IntList[MidIndex] < SearchValue)
            {
                startIndex = MidIndex;
                Method1(IntList, SearchValue, startIndex, endIndex);
            }
            else if (IntList[MidIndex] == SearchValue)
            {
                //DateTime end = DateTime.Now;

                Console.WriteLine("Index: " + MidIndex);
                Console.WriteLine();
                Console.WriteLine();
                //Console.WriteLine((end - start).TotalSeconds.ToString() + " Method1 Seconds");
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
            }



        }
    }
}
