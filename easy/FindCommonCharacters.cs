using System.Collections.Generic;

namespace Leetcode.easy
{
  public class FindCommonCharacters
  {
    public IList<string> CommonChars(string[] A)
    {
      var a = new int[52];
      foreach (var c in A[0])
      {
        a[c - 97]++;
      }
      for (int i = 1; i < A.Length; i++)
      {
        foreach (var c in A[i])
        {
          a[c - 97 + 26]++;
        }
        for (int j = 0; j < 26; j++)
        {
          a[j] = a[j] > a[j + 26] ? a[j + 26] : a[j];
          a[j + 26] = 0;
        }
      }

      var result = new List<string>();
      for (int i = 0; i < 26; i++)
      {
        for (int j = 0; j < a[i]; j++)
        {
          result.Add(((char)(i + 97)).ToString());
        }
      }
      return result;
    }
  }
}