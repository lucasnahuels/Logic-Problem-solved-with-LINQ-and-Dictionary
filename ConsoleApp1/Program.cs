using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] numbers = new short[] { 4, 2, 5, 6, 2, 4, 2, 3 };

            //short[] orderedNumbers = OrderHelper.FirstShot(numbers);

            //for (var i = 0; i < orderedNumbers.Length; i++)
            //{
            //    Console.WriteLine(orderedNumbers[i]);
            //}

            //------------------------------------------------------------

            //short[] orderedNumbers2 = OrderHelper.SecondShot(numbers);

            //for (var i = 0; i < orderedNumbers2.Length; i++)
            //{
            //    Console.WriteLine(orderedNumbers2[i]);
            //}


            short[] orderedNumbers3 = OrderHelper.ThirdShot(numbers);

            for (var i = 0; i < orderedNumbers3.Length; i++)
            {
                Console.WriteLine(orderedNumbers3[i]);
            }
        }
    }
}