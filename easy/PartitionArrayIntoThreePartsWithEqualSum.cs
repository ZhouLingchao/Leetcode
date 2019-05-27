using System.Linq;

namespace Leetcode.easy
{
  public class PartitionArrayIntoThreePartsWithEqualSum
  {
    public bool CanThreePartsEqualSum(int[] A)
    {
      var sum = A.Sum();
      if (sum % 3 != 0) return false;
      var target = sum /3;

      var s = 0;
      var count = 0;
      foreach (var item in A)
      {
          s += item;
          if(s == target) {
            s = 0;
            count++;
            if(count == 2) return true;
          }
      }
      return false;
    }
  }
}