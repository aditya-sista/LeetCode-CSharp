using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLC
{
    /// <summary>
    /// 3Sum
    /// </summary>
    public class LC15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                // If we encounter the same number, continue;
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    if (sum < 0) ++j;
                    else if (sum > 0) --k;
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                        // we got the result, increment j and decrement k.
                        ++j; --k;
                        
                        // if there is a same nums[j] after current, skip it.
                        while (j < k && nums[j] == nums[j - 1]) ++j;
                        // if there is a same nums[k] before current, skip it.
                        while (j < k && nums[k + 1] == nums[k]) --k;
                    }
                }
            }
            return result;
        }
    }
}
