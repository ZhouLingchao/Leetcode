using System.Collections.Generic;

namespace Leetcode.easy
{
  public class VerifyingAnAlienLanguage
  {
    public bool IsAlienSorted(string[] words, string order)
    {
      var orders = new int[26];
      for (int i = 0; i < 26; i++)
      {
        orders[order[i] - 'a'] = i;
      }
      for (int i = 0; i < words.Length - 1; i++)
      {
        var a = words[i];
        var b = words[i + 1];
        var j = 0;
        var isBigger = false;
        while (j < a.Length && j < b.Length)
        {
          if (orders[a[j] - 'a'] < orders[b[j] - 'a'])
          {
            isBigger = true;
            break;
          }
          else if (orders[a[j] - 'a'] > orders[b[j] - 'a'])
          {
            return false;
          }
          else
          {
            j++;
          }
        }
        if (!isBigger && b.Length < a.Length) return false;
      }
      return true;
    }
  }
}