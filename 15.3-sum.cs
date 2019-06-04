/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */
using System;
using System.Collections.Generic;

public class ThreeSum {
    public IList<IList<int>> ThreeSu(int[] nums) {
         var list = new List<IList<int>>();
        if(nums.Length<3) return list;
        Array.Sort(nums);
        var prev = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if(i>0&& nums[i] == prev){
                prev = nums[i];
                continue;
            }else prev = nums[i];
            int start = i+1, end = nums.Length-1;
            while(start < end){
                var sum = nums[i] + nums[start]+nums[end] ;
                if(sum== 0) {
                    list.Add(new List<int>(){nums[i],nums[start],nums[end]});
                    while(nums[start+1] == nums[start++]);
                    while(nums[end-1] == nums[end--]);
                }
                else if(sum > 0 ) end--;
                else start++; 
            }

        }
        return list;
    }
}

