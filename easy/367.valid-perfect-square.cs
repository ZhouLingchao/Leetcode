/*
 * @lc app=leetcode id=367 lang=csharp
 *
 * [367] Valid Perfect Square
 */
public class ValidPerfectSquare {
    public bool IsPerfectSquare(int num) {
       int start = 1, end = num ;
        long middle = (num+1)/2;
        while(start != middle){
            var product = middle * middle;
            if(num == product) return  true;
            else if(num > product) start = (int)middle;
            else end = (int)middle;
            middle = (start + end )/2;
        }
        return start* start ==num || end * end == num;
    }
}

