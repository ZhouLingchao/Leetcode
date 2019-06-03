/*
 * @lc app=leetcode id=594 lang=csharp
 *
 * [594] Longest Harmonious Subsequence
 */
using System;
using System.Collections.Generic;
using System.Linq;

public class LongestHarmoniousSubsequence {
    public int FindLHS(int[] nums) {
        var max = 0;
        var d = new Dictionary<int,int>();
        foreach (var val in nums)
        {
            if(d.ContainsKey(val)) d[val]++;
            else d.Add(val,1);
        }
        if(d.Count < 2 ) return 0;
        
        foreach (var item in d)
        {
            if(d.ContainsKey(item.Key-1)) max = Math.Max( max,item.Value+d[item.Key-1]);
            if(d.ContainsKey(item.Key+1)) max = Math.Max( max,item.Value+d[item.Key+1]);
        }
        return max;
    }
}

