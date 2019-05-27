using System.Collections;
using System.Collections.Generic;

namespace Leetcode.easy
{
  public class TwoCityScheduling
  {
    public int TwoCitySchedCost(int[][] costs)
    {
      var list = new List<Model>(costs.Length);
      for (int i = 0; i < costs.Length; i++) list.Add(new Model { Index = i, value = costs[i][0] - costs[i][1] });
      list.Sort((a, b) => a.value - b.value);
      int sum = 0, count = costs.Length / 2;
      foreach (var item in list) if (count-- > 0) sum += costs[item.Index][0]; else sum += costs[item.Index][1];
      return sum;
    }
    private class Model
    {
      public int Index { get; set; }
      public int value { get; set; }
    }
  }
}