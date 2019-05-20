using System;
using System.Collections.Generic;

namespace Leetcode.medium
{
  public class RevealCardsInIncreasingOrder
  {
    public int[] DeckRevealedIncreasing(int[] deck)
    {
      if(deck.Length==1) return deck;
      Array.Sort(deck);
      var list = new LinkedList<int>();
      for (int i = 0; i < deck.Length; i++)
      {
        list.AddLast(i);
      }
      var index = list.First;
      var tempArray = new int[deck.Length];
      for (int i = 0; i < deck.Length - 2; i++)
      {
        tempArray[i] = index.Value;
        index = index.Next;
        list.AddLast(index.Value);
        index = index.Next;
      }
      tempArray[deck.Length-2] = index.Value;
      tempArray[deck.Length-1] = index.Next.Value;
      
      var result = new int[deck.Length];
      for (int i = 0; i < deck.Length; i++)
      {
          result[tempArray[i]] = deck[i];
      }
      return result;
    }
  }
}