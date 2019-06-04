/*
 * @lc app=leetcode id=1018 lang=csharp
 *
 * [1018] Binary Prefix Divisible By 5
 */
using System.Collections.Generic;

public class BinaryPrefixDivisibleBy5 {
    public IList<bool> PrefixesDivBy5(int[] A) {
        var val = A[0];
        var list = new List<bool>(A.Length){val == 0};
        for (int i = 1; i < A.Length; i++)
        {
            val = (val *2 +A[i] ) % 10;
            list.Add(val%5==0);
        }
        return list;
    }
}

