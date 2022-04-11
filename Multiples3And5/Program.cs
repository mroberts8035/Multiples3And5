﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             If we list all the natural numbers below 10
                that are multiples of 3 or 5, we get 3, 5,
                6 and 9. The sum of these multiples is 23.

                Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.
             */

            var multiples = new List<int>();

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                    //Console.WriteLine(i);
                }
            }

            Console.WriteLine($"The sum of all the multiples of either 3 or 5 below 1000 equals: {multiples.Sum()}");

        }
    }
}
