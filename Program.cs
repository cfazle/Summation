using System;
using System.Collections.Generic;
using System.Linq;

namespace Summation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare two collections of int elements.
            int[] array1 = { 1, 3, 5, 7 };

            List<int> list1 = new List<int>() { 1, 3, 5, 9 };

            //Use Sum extension on their elements
            int sum1 = array1.Sum();
            int sum2 = list1.Sum();

            Console.WriteLine("Sum of array:" + sum1);
            Console.WriteLine("Sum of List:" + sum2);
        }
    }
}
