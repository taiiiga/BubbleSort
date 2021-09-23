using System;
using TopLibrary;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {800,11,50,771,649,770,240, 9};
            var output = Sorter.sort(arr);
            foreach (var t in output)
            {
                Console.WriteLine(t);
            }
        }
    }
}