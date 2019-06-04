/*
 * @lc app=leetcode id=989 lang=csharp
 *
 * [989] Add to Array-Form of Integer
 */
using System;
using System.Collections.Generic;
using System.Linq;

public class AddtoArrayFromOfInteger {
    public IList<int> AddToArrayForm(int[] A, int K) {
        var list = A.ToList();
        var i = 0;
        var kStr = K.ToString();
        var carry = false;
        while(i<kStr.Length){
            var val = Convert.ToInt32( kStr[kStr.Length - 1- i].ToString());
            if(i<A.Length){
                var sum = val + A[A.Length-1-i] + (carry?1:0);
                if(sum> 9 ) carry = true; else carry = false;
                list[A.Length-1-i] = sum > 9 ? sum - 10 : sum;
                
            }else{
                if(val == 9 && carry ) list.Insert(0,0);
                else {
                    list.Insert(0,val+ (carry?1:0));
                    carry = false;
                }
            }
            i++;
        }
        while(carry){
            if(i == list.Count) {
                list.Insert(0,1);
                break;
            }
            if(list[A.Length-1-i] == 9) list[A.Length-1-i] = 0;
            else {
                list[A.Length -1-i]++;
                carry = false;
            }
            i++;
        }
        return list;
    }
}

