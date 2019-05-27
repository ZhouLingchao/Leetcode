namespace Leetcode.easy
{
  public class CountBinarySubstrings
  {
    public int CountBinarySubstring(string s)
    {
      int prevCount = 0, currCount = 1, index = 1, count = 0;
      char prev = '2', curr = s[0];
      while (index < s.Length)
      {
        if (s[index] != curr)
        {
          if (prev != '2') count += prevCount > currCount ? currCount : prevCount;
          prev = curr;
          prevCount = currCount;
          curr = s[index];
          currCount = 1;

        }
        else currCount++;
        index++;
      }
      return count + (prevCount > currCount ? currCount : prevCount);
    }
  }
}