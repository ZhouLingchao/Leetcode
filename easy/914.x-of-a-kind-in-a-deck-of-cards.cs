/*
 * @lc app=leetcode id=914 lang=csharp
 *
 * [914] X of a Kind in a Deck of Cards
 */
using System.Collections.Generic;
using System.Linq;

public class XOfAKindInADeckOfCards {
    public bool HasGroupsSizeX(int[] deck) {
        var d  = new Dictionary<int,int>();
        foreach (var item in deck)
        {
            if(d.ContainsKey(item)) d[item]++;
            else d.Add(item,1);
        }
        var min = d.Values.Min();
        while(min>=2){
            var b = true;
            foreach (var item in d.Values)
            {
                if(item % min !=0){
                    b =false;
                    break;
                }
            }
            if(b) return true;
            min--;
        }
        return false;
    }
}

