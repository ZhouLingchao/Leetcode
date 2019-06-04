/*
 * @lc app=leetcode id=844 lang=csharp
 *
 * [844] Backspace String Compare
 */
public class BackspaceStringCompare
{
  public bool BackspaceCompare(string S, string T)
  {
    int si = S.Length - 1, ti = T.Length - 1, st = 0, tt = 0;
    while (si > -1 || ti > -1)
    {
      if (si > -1)
      {
        if (S[si] == '#')
        {
            si--;
          st++;
          continue;
        }
        if (st > 0)
        {
          si--;
          st--;
          continue;
        }
      }
      if (ti > -1)
      {
        if (T[ti] == '#')
        {
            ti--;
          tt++;
          continue;
        }
        if (tt > 0)
        {
          ti--;
          tt--;
          continue;
        }
      }

      if ((si < 0 || ti < 0) || S[si--] != T[ti--]) return false;
    }
    return true;

  }
}

