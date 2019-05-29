using System.Collections.Generic;

namespace Leetcode.easy
{
  public class RottingOranges
  {
    public int OrangesRotting(int[][] grid)
    {
        var rottedSet = new HashSet<int>();
        var freshSet = new HashSet<int>();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 1){
                    freshSet.Add(i*10+j);
                }else if(grid[i][j] == 2){
                    rottedSet.Add(i*10+j);
                }
            }
        }
        if(freshSet.Count==0) return 0;
        
    }
  }
}