using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackCodingSharp
{
    class MaxProfit
    {
        //Max profit
        //Instead of keeping track of largest element in the array,
        //this track the maximum profit so far.
        public static long solution(long[] prices)
        {
            if (prices == null || prices.Count() <= 1)
                return 0;

            long min = prices[0]; // min so far
            long result = 0;

            for (int i = 1; i < prices.Count(); i++)
            {
                result = Math.Max(result, prices[i] - min);
                min = Math.Min(min, prices[i]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            long[] arr = new long[] { 5, 2, 1, 10, 6 };
            solution(arr);
        }
    }

}
