using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpPrograms
{
    internal class FindMaxnum
    {
        public static void maxelement(int num_rows, int[][] arr)
        {
            int i = 0;
            int max = 0;

            int[] result = new int[num_rows];
            while (i < num_rows)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }
                result[i] = max;
                max = 0;
                i++;
            }
            printArray(result);
        }
        static void printArray(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[] { 5, 9, 1, 6 },
                new int[] { 8, 3, 5, 4 },
                new int[] { 8, 6, 7, 3 }
            };

            maxelement(3, arr);
        }
    }
}
