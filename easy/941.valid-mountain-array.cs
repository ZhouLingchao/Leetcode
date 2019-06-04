/*
 * @lc app=leetcode id=941 lang=csharp
 *
 * [941] Valid Mountain Array
 */
public class ValidMountainArray {
    public bool ValidMountainArra(int[] A) {
        if(A.Length<3) return false;
        var asc = true;
        for (int i = 1; i < A.Length; i++)
        {
            if(A[i]==A[i-1])return false;
            else if(A[i]>A[i-1]){
                if(!asc) return false;
            }else{
                if(i == 1) return false;
                asc = false;
            }
        }
        return !asc;
    }
}

