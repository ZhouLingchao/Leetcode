namespace Leetcode.easy
{
  public class SumOfEvenNumbersAfterQueries
  {
    public int[] SumEvenAfterQueries(int[] A, int[][] queries)
    {
      var sum = 0;
      for (int i = 0; i < A.Length; i++)
      {
        if (A[i] % 2 == 0) sum += A[i];
      }
      var sumList = new int[queries.Length];
      for (int i = 0; i < queries.Length; i++)
      {
        var value = queries[i][0];
        var index = queries[i][1];
        var oldValue = A[index];
        var newValue = oldValue + value;
        if (oldValue % 2 == 0)
        {
          sum -= oldValue;
        }
        if (newValue % 2 == 0)
        {
          sum += newValue;
        }
        sumList[i] = sum;
        A[index] = newValue;
      }
      return sumList;
    }
  }
}