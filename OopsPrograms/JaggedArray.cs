using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            // Jagged array
            // it is aslo called as array of arrays
            // in C# Jagged array can be used when row size is fixed but column size is vary

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 100, 200, 300 };
            jaggedArray[2] = new int[] { 10, 20 };

            for (int i = 0; i < jaggedArray.Length; i++) // row -3
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) //  [0] --> 5
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
