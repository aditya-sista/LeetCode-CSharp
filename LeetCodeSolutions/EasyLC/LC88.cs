using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EasyLC
{
    /// <summary>
    /// Merge Sorted Array.
    /// </summary>
    public class LC88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len1 = nums1.Length - 1;

            // Start merging from the last of nums1.
            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[len1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[len1] = nums2[n - 1];
                    n--;
                }
                len1--;
            }

            // Edge case - when all the elemets of nums1 are traversed,
            // and there are elements still in nums2,
            // copy the remaining elements of nums2 over to nums1.
            while (n > 0)
            {
                nums1[len1] = nums2[n - 1];
                len1--;
                n--;
            }
        }
    }
}
