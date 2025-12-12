using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class Problem217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            //{ 1,2,3,4,1,5 } : O(n^2)
            //for(int i = 0; i< nums.Length - 1; i++)
            //{
            //    for(int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[j] == nums[i])
            //            return true;
            //    }
            //}
            //return false;

            //{ 1,2,3,4,1,5 } : O(n)
            HashSet<int> distNums = new HashSet<int>();
                
            foreach(int num in nums)
            {
                if(!distNums.Add(num))
                    return true;
            }
            return false;
        }
    }
}
