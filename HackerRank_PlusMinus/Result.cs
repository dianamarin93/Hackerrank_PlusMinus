using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_PlusMinus
{
    class Result
    {
        // Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.Print the decimal value of each fraction on a new line with 6 places after the decimal.

        public static void PlusMinus(List<int> arr)
        {
            int negativeCounter = 0;
            int positiveCounter = 0;
            int zeroCounter = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < 0)
                {
                    negativeCounter++;
                } 
                else if (arr[i] > 0)
                {
                    positiveCounter++;
                }
                else
                {
                    zeroCounter++;
                }

            }
            Console.WriteLine(((double)negativeCounter / arr.Count).ToString("0.0000000"));
            Console.WriteLine(((double)positiveCounter / arr.Count).ToString("0.0000000"));
            Console.WriteLine(((double)zeroCounter / arr.Count).ToString("0.0000000"));
        }
    }
}
