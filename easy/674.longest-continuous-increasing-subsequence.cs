/*
 * @lc app=leetcode id=674 lang=csharp
 *
 * [674] Longest Continuous Increasing Subsequence
 */
using System;

public class LongestContinuousIncreasingSubsequence
{
  public int FindLengthOfLCIS(int[] nums)
  {
    if (nums.Length < 2) return nums.Length;
    int max = 0, prev = nums[0], count = 1;
    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] > prev) count++;
      else
      {
        max = Math.Max(max, count);
        count = 1;
      }
      prev = nums[i];
    }
    max = Math.Max(max, count);
    return max;
  }
}

