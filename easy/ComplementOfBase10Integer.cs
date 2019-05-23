using System;
using System.Text;
namespace Leetcode.easy
{
  public class ComplementOfBase10Integer
  {
    public int BitwiseComplement(int N)
    {
      var s = Convert.ToString(N, 2);
      var sb = new StringBuilder();
      foreach (var c in s)
      {
        sb.Append(c == '1' ? '0' : '1');
      }
      return Convert.ToInt32(sb.ToString(), 2);
    }
  }
}