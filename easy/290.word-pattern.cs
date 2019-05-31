/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 */
using System.Collections.Generic;

public class Solution {
    public bool WordPattern(string pattern, string str) {
        var arr = new string[26];
        var set = new HashSet<string>();
        var sArray = str.Split(' ');
        if(pattern.Length != sArray.Length ) return false;
        for (int i = 0; i < pattern.Length ; i++)
        {
            var index = (int)(pattern[i] - 'a');
            if(string.IsNullOrEmpty(arr[index])) {
                arr[index] = sArray[i];
                if(!set.Add(sArray[i])) return false;
            }
            else if(arr[index]!=sArray[i]) return false;
        }
        return true;
    }
}

