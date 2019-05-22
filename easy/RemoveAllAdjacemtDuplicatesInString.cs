using System;
using System.Collections;
using System.Collections.Generic;

namespace Leetcode.easy
{
  public class RemoveAllAdjacemtDuplicatesInString
  {
    public string RemoveDuplicates(string S)
    {
        var stack = new Stack<char>();
        foreach (var c in S)
        {
            if(stack.Count != 0 && stack.Peek() == c ) stack.Pop();
            else stack.Push(c);
        }
        var chars = new char[stack.Count];
        for (int i = stack.Count-1; i >=0 ; i--)
        {
            chars[i] = stack.Pop();
        }
        return new string(chars);
    }
  }
}