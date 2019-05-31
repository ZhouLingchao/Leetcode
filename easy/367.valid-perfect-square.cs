/*
 * @lc app=leetcode id=367 lang=csharp
 *
 * [367] Valid Perfect Square
 */
public class Solution {
    public bool IsPerfectSquare(int num) {
        int start = 1, end = 44721,middle = 22361;
        if(num>end) return false;
        while(start != middle){
            var product = middle * middle;
            if(num == product) return  true;
            else if(num > product) start = middle;
            else end = middle;
            middle = (start + end )/2;
        }
        return start* start ==num || end * end == num;
    }
}

