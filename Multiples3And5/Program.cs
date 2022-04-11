using System;
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

            //Initated a list to add the multiples to
            var multiples = new List<int>();

            //Created a For loop to check the numbers below 1000
            for (int i = 1; i < 1000; i++)
            {
                //Used modulus to see if the numbers are a multiple of either 3 or 5
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //If the numbers are a multiple add it to the list created above
                    multiples.Add(i);
                    //This CW is to test that I am getting the right stuff added to the list then I commented it out
                    //Console.WriteLine(i);
                }
            }

            //Printing out a sum of the list with a string for better UX
            Console.WriteLine($"The sum of all the multiples of either 3 or 5 below 1000 equals: {multiples.Sum():n0}");

        }
    }
}
