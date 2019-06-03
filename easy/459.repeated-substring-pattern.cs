/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 */
using System;
using System.Collections.Generic;
using System.Linq;

public class RepeatedSubstringPattern {
    public bool RepeatedSubstringPatter(string s) {
        for (int i = s.Length / 2; i>= 1; i--)
        {
            if(s.Length%i!=0) continue;
            bool b = true;
            for (int j = 0; j < s.Length - i; j++)
            {
                if(s[j] != s[j+ i]) {
                    b = false;
                    break;
                } 
            }
            if(b) return true;
        }
        return false;
    }

}

