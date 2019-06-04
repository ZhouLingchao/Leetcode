/*
 * @lc app=leetcode id=724 lang=csharp
 *
 * [724] Find Pivot Index
 */
public class FindPivotIndex {
    public int PivotIndex(int[] nums) {
        var sum = 0;
        foreach (var n in nums)
        {
            sum+=n;
        }
        var half = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if(half*2 + nums[i] == sum) return i;
            half += nums[i];
        }
        return -1;
    }
}

