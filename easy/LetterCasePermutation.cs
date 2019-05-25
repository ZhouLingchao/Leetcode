using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.easy
{
  public class LetterCasePermutation
  {
    public IList<string> LetterCasePermutatio(string S)
    {
      var list = new List<string>(;
      Add(list,  S, 0, "");
      return list;
    }

    private void Add(IList<string> list,  string S, int depth, string s)
    {
      if (depth == S.Length)
      {
        list.Add(s);
      }
      else
      {
        if (S[depth] >= 'A')
        {
          Add(list,  S, depth + 1, s+Char.ToLower(S[depth]));
          Add(list,  S, depth + 1, s+Char.ToUpper(S[depth]));
        }
        else
        {
          Add(list,  S, depth + 1, s+S[depth]);
        }
      }
    }
  }
}