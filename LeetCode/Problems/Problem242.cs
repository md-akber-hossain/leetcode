using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class Problem242
    {
        // "ggii", "igig" : O(n^2) 5%
        //public bool IsAnagram(string s, string t)
        //{
        //    if(s.Length != t.Length) return false;

        //    for(int i=0; i<s.Length; i++)
        //    {
        //        for(int j=0; j<t.Length; j++)
        //        {
        //            if(s[i] == t[j])
        //            {
        //                t = t.Remove(j, 1);
        //                break;
        //            }
        //        }
        //    }

        //    return t.Length == 0;
        //}

        // "ggii", "igig" : O(n) 73%
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            int[] countArray = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                countArray[s[i] - 97]++;
                countArray[t[i] - 97]--;
            }

            foreach (int i in countArray) 
            {
                if(i != 0)
                    return false;
            }

            return true;
        }
    }
}
