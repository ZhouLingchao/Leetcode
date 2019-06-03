/*
 * @lc app=leetcode id=581 lang=csharp
 *
 * [581] Shortest Unsorted Continuous Subarray
 */
using System;

public class ShortestUnsortedContinuousSubarray {
    public int FindUnsortedSubarray(int[] nums) {
        if(nums.Length < 2 ) return 0;
        int i = 1, j = nums.Length - 2, min = nums[nums.Length -1], max = nums[0],start = 0 ,end = nums.Length-1;
        while(i<nums.Length){
            max = Math.Max(max,nums[i]);
            if(nums[i] < nums[i-1]) break;
            i++;
        }
        if(i == nums.Length) return 0;
        while(j >= 0){
            min = Math.Min(min,nums[j]);
            if(nums[j] > nums[j+1] ) break;
            j--;
        }
        while(i<=j){
            max = Math.Max(max,nums[i]);
            min = Math.Min(min,nums[i]);
            i++;
        }

        while(start< i ){
            if(nums[start] > min) break;
            start++;
        }
        while(end > j){
            if(nums[end] < max) break;
            end--;
        }
        return end - start + 1;

    }
}

