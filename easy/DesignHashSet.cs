namespace Leetcode.easy
{
  public class DesignHashSet
  {
    private Node[] _data;
    private const int SIZE = 1000;
    /** Initialize your data structure here. */
    public DesignHashSet()
    {
      _data = new Node[SIZE];
    }

    public void Add(int key)
    {
      var remainder = key % SIZE;
      if (_data[remainder] == null) _data[remainder] = new Node(key);
      else
      {
        var current = _data[remainder];
        while (null != current.Next)
        {
          if (current.Key == key) return;
          current = current.Next;
        }
        if (current.Key == key) return;
        current.Next = new Node(key);
      }
    }

    public void Remove(int key)
    {
      var remainder = key % SIZE;
      if (_data[remainder] == null) return;
     
      Node current = _data[remainder];
      if(current.Key == key) {
          _data[remainder] = current.Next;
          return;
      }
      var prev = current;
      current = current.Next;
      while (null != current){
          if(current.Key == key){
              prev.Next = current.Next;
              return;
          }else{
              prev = current;
              current = current.Next;
          }
      }
    }

    /** Returns true if this set contains the specified element */
    public bool Contains(int key)
    {
      var remainder = key % SIZE;
      if (_data[remainder] == null) return false;
      var current = _data[remainder];
      while (null != current)
      {
        if (current.Key == key) return true;
        current = current.Next;
      }
      return false;
    }

    private class Node
    {
      public Node(int key)
      {
        Key = key;
      }
      public int Key { get; set; }
      public Node Next { get; set; }
    }
  }
}