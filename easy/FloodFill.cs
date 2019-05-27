using System.Collections.Generic;

namespace Leetcode.easy
{
  public class FloodFill
  {
    public int[][] FloodFil(int[][] image, int sr, int sc, int newColor)
    {
      Fill(image, sr , sc, newColor, new HashSet<int>(), image[sr][sc]);
      return image;
    }

    private void Fill(int[][] image, int sr, int sc, int newColor, HashSet<int> set, int target)
    {
      if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || !set.Add(sr * 50 + sc) || image[sr][sc] != target) return;
      image[sr][sc] = newColor;
      Fill(image, sr + 1, sc, newColor, set, target);
      Fill(image, sr, sc + 1, newColor, set, target);
      Fill(image, sr - 1, sc, newColor, set, target);
      Fill(image, sr, sc- 1, newColor , set, target);
    }
  }
}