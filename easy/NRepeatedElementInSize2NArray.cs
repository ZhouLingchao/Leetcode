using System.Collections.Generic;

namespace Leetcode.easy
{
  public class NRepeatedElementInSize2NArray
  {
    public int RepeatedNTimes(int[] A)
    {
        var dic = new HashSet<int>();
        foreach (var item in A)
        {
            if(!dic.Add(item)) return item;
        }
        return -1;
    }
  }
}