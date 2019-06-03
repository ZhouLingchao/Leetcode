/*
 * @lc app=leetcode id=605 lang=csharp
 *
 * [605] Can Place Flowers
 */
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i] == 1) continue;
            if(i-1>=0 && flowerbed[i-1] == 1) continue;
            if(i+1<flowerbed.Length && flowerbed[i+1] == 1) continue;
            count++;
            i++;
        }
        return count>=n;
    }
}

