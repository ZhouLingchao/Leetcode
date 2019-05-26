using System.Linq;

namespace Leetcode.easy
{
  public class PartitionArrayIntoThreePartsWithEqualSum
  {
    public bool CanThreePartsEqualSum(int[] A)
    {
      var sum = A.Sum();
      if (sum % 3 != 0) return false;
      
    }
  }
}