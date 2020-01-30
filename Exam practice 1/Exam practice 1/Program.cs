using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Uber");
            // Test Cases
            int[] arrInput = { 1, 2, 3 };
            // Output Array
            int[] arrOutput = new int[arrInput.Length];

            int result = 1; // initializing to 1 because 0 * X = 0

            // for i
            for (int i = 0; i < arrInput.Length; i++)
            {
                // so if Length = 3
                // I will do i = 0, i = 1, i = 2 passes
                

                // for j
                for (int j = 0; j < arrInput.Length; j++)
                {

                    // print to demonstrate
                    if (i != j)
                    {
                        result *= arrInput[j];
                    }
                    //  i = 0
                    
                }
                // show Output
                arrOutput[i] = result;
                result = 1;

            }
            for (int x = 0; x < arrOutput.Length; x++)
            {
                Console.WriteLine(arrOutput[x]);
            }


            Console.ReadKey();
        }
    }
}