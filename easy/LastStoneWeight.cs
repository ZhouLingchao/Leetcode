using System;
using System.Collections.Generic;

namespace Leetcode.easy
{
  public class LastStoneWeight
  {
    public int LastStoneWeigh(int[] stones)
    {
      Array.Sort(stones);
      var orderedList = new LinkedList<int>(stones);
      while(orderedList.Count>1){
        var a = orderedList.Last;
        var b = a.Previous;
        if(a.Value==b.Value) {
          orderedList.RemoveLast();
          orderedList.RemoveLast();
        }else{
          var value = a.Value-b.Value;
          orderedList.RemoveLast();
          orderedList.RemoveLast();
          var index = orderedList.First;
          bool used = false;
          while(index!=null){
            if(index.Value>value){
              used = true;
              orderedList.AddBefore(index,value);
              break;
            } 
            else index = index.Next;
          }
          if(!used)orderedList.AddLast(value);
        }
      }

      return orderedList.Count ==0 ?0:orderedList.First.Value;
    }
  }
}