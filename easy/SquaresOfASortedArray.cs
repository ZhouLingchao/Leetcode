namespace Leetcode.easy
{
  public class SquaresOfASortedArray
  {
    public int[] SortedSquares(int[] A)
    {
      var index = 0;
      if (A[A.Length - 1] <= 0) index = A.Length;
      else
      {
        for (int i = 0; i < A.Length; i++)
        {
          if (A[i] > 0)
          {
            index = i;
            break;
          }
        }
      }

      var result = new int[A.Length];
      if (index > 0)
      {
        var reverseIndex = index - 1;
        var i = 0;
        while (reverseIndex >= 0 || index < A.Length)
        {
          int smaller;
          if (reverseIndex < 0) smaller = A[index++];
          else if (index >= A.Length) smaller = A[reverseIndex--];
          else smaller = A[index] + A[reverseIndex] > 0 ? A[reverseIndex--] : A[index++];
          result[i++] = smaller * smaller;
        }
      }
      else
      {
        for (int i = 0; i < A.Length; i++)
        {
          result[i] = A[i] * A[i];
        }
      }
      return result;
    }
  }
}