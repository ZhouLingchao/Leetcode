namespace Leetcode.easy
{
  public class FindTheTownJudge
  {
    public int FindJudge(int N, int[][] trust)
    {
      var array = new int[N+1];
      foreach (var item in trust)
      {
        array[item[0]] = -1;
        if (array[item[1]] != -1)
        {
          array[item[1]]++;
        }
      }
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == N - 1) return i;
      }
      return -1;
    }
  }
}