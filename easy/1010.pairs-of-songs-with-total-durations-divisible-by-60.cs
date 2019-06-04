/*
 * @lc app=leetcode id=1010 lang=csharp
 *
 * [1010] Pairs of Songs With Total Durations Divisible by 60
 */
using System.Collections.Generic;
using System.Linq;

public class PairsOfSongsWithTotalDurationsDivisibleBy60 {
    public int NumPairsDivisibleBy60(int[] time) {
        var count = 0;
        var d = new Dictionary<int,int>();
        foreach (var n in time)
        {
            var remainder = n % 60;
            if(d.ContainsKey(remainder)) d[remainder]++;
            else d.Add(remainder ,1);
        }

        var keys = d.Keys.ToList();
        foreach (var k in keys)
        {
            if((k == 30 || k == 0)) {
                if(d[k] > 1) count += (1 + d[k] - 1) * (d[k] - 1) /2 ;
            }
            else if(d.ContainsKey(60-k)) count += d[k] * d[60-k];
            d.Remove(k);
        }

        return count;
    }
}

