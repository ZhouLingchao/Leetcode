using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.easy
{
  public class LargestPerimeterTriangle
  {
    // sort first
    public int LargestPerimeter(int[] A)
    {
      Array.Sort(A);
      var index = A.Length - 3;
      while (index >= 0)
      {
        if (A[index] + A[index + 1] > A[index + 2]) return A[index] + A[index + 1] + A[index + 2];
        index--;
      }
      return 0;
    }
  }
}