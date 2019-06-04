/*
 * @lc app=leetcode id=849 lang=csharp
 *
 * [849] Maximize Distance to Closest Person
 */
using System;

public class MaximizeDistanceToClosestPerson {
    public int MaxDistToClosest(int[] seats) {
        int start = - 1 , max = 0 ;
        for (int i = 0; i < seats.Length; i++)
        {
            if(seats[i] == 1){
                if(start == -1) max = Math.Max(max, i - start -1 );
                else max = Math.Max(max, (i - start -1)/2 +1 );
                start = i;
            }
        }
        max = Math.Max(max, seats.Length - start -1 );
        return max;
    }
}

