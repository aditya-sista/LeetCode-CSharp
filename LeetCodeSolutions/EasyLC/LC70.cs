using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLC
{
    /// <summary>
    /// Climbing stairs.
    /// </summary>
    public class LC70
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            // These two variables keep track of only the previous two counts,
            // because the sum of these two would be the count of the current stair.
            int prev1 = 1;
            int prev2 = 2;

            int count = 0;
            for (int i = 2; i < n; ++i)
            {
                count = prev1 + prev2;
                prev1 = prev2;
                prev2 = count;
            }
            return count;
        }
    }
}
