/*
 * @lc app=leetcode id=168 lang=csharp
 *
 * [168] Excel Sheet Column Title
 *
 * https://leetcode.com/problems/excel-sheet-column-title/description/
 *
 * algorithms
 * Easy (28.98%)
 * Likes:    708
 * Dislikes: 141
 * Total Accepted:    172.3K
 * Total Submissions: 594.5K
 * Testcase Example:  '1'
 *
 * Given a positive integer, return its corresponding column title as appear in
 * an Excel sheet.
 * 
 * For example:
 * 
 * 
 * ⁠   1 -> A
 * ⁠   2 -> B
 * ⁠   3 -> C
 * ⁠   ...
 * ⁠   26 -> Z
 * ⁠   27 -> AA
 * ⁠   28 -> AB 
 * ⁠   ...
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: 1
 * Output: "A"
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: 28
 * Output: "AB"
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: 701
 * Output: "ZY"
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string ConvertToTitle(int n) {
        var chars = new List<char>();
        while(n-- >0){
            chars.Add(((char)(n%26 + 'A')));
            n /= 26;
        }
        chars.Reverse();
        return new string(chars.ToArray());
    }
}

