using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.easy
{
  public class MaximizeSumOfArrayAfterKNegations
  {
    public int LargestSumAfterKNegations(int[] A, int K)
    {
      var list = A.Where(x => x < 0).OrderBy(x=>x).ToList();
      return A.Sum() - list.Take( K > list.Count ? list.Count : K).Sum() * 2 - ( K > list.Count && (K - list.Count) % 2 == 1 ?  Math.Abs(A.Min(x => Math.Abs(x))) * 2 : 0);
    }
  }
}