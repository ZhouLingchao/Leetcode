using System.Collections.Generic;
using System.Linq;

namespace Leetcode.easy
{
  public class FairCandySwap
  {
    public int[] FairCandySwa(int[] A, int[] B)
    {
        var diff = (A.Sum() - B.Sum())/2;
        var dic = new HashSet<int>(B.Length);
        for (int i = 0; i < B.Length; i++)
        {
            dic.Add(B[i]);
        }
        foreach (var i in A)
        {
            if( dic.Contains(i-diff)) return new int[]{i,i-diff};
        }
        return null;
    }

  }
}