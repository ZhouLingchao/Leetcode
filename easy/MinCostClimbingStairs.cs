namespace Leetcode.easy
{
  public class MinCostClimbingStairs
  {
    public int MinCostClimbingStairs(int[] cost)
    {
        int i =0,sum=0;
        while(i<cost.Length-1){
            if(i == cost.Length-2) return sum+ cost[i]>cost[i+1]?cost[i+1]:cost[i];
            if(cost[i+1]<)
        }
    }
  }
}