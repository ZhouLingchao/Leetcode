namespace Leetcode.easy
{
  public class DIStringMatch
  {
    public int[] DiStringMatch(string S)
    {
        int start = 0,end = S.Length;
        var result = new int[S.Length+1];
        for (int i = 0; i < S.Length; i++)
        {
            if(S[i]=='I') result[i] = start++;
            else result[i] = end--;
        }
        result[S.Length] = start;
        return result;
    }
  }
}