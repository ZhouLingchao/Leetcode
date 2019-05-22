using System;
using System.Collections.Generic;

namespace Leetcode.easy
{
  public class MatrixCellsInDistanceOrder
  {
    public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
    {
      var r = new List<int[]>(R * C);
      var temp = new List<int[]>[R + C - 1];
      for (int i = 0; i < R; i++)
      {
        for (int j = 0; j < C; j++)
        {
          var distance = Math.Abs(i - r0) + Math.Abs(j - c0);
          if (temp[distance] == null) temp[distance] = new List<int[]>();
          temp[distance].Add(new int[] { i, j });
        }
      }
      for (int i = 0; i < temp.Length; i++)
      {
        if (temp[i] != null)
        {
          r.AddRange(temp[i]);
        }
      }

      return r.ToArray();
    }
  }
}