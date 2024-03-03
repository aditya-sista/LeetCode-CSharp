using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLC
{
    /// <summary>
    /// Two Sum II - Input Array Is Sorted.
    /// </summary>
    public class LC167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                var twoSum = numbers[left] + numbers[right];
                if (twoSum == target)
                {
                    result[0] = ++left;
                    result[1] = ++right;
                    return result;
                }
                else if (twoSum < target) ++left;
                else --right;
            }
            return result;
        }
    }
}
