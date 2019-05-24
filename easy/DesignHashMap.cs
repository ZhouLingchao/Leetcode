namespace Leetcode.easy
{
  public class DesignHashMap
  {
    private Node[] _data;
    private const int SIZE = 1001;
    /** Initialize your data structure here. */
    public DesignHashMap()
    {
      _data = new Node[SIZE];
    }

    /** value will always be non-negative. */
    public void Put(int key, int value)
    {
      var remainder = key % SIZE;
      if (_data[remainder] != null)
      {
        var index = _data[remainder];
        do
        {
          if (index.Key == key)
          {
            index.Value = value;
            return;
          }
          index = index.Next;
        } while (index.Next != null);
        index.Next = new Node(key, value);
      }
      else
      {
        _data[remainder] = new Node(key, value);
      }
    }

    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key)
    {
      var item = _data[key % SIZE];
      if (null == item) return -1;
      while (item != null)
      {
        if (item.Key == key) return item.Value;
        item = item.Next;
      }
      return -1;
    }

    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key)
    {
      var remainder = key % SIZE;
      var item = _data[remainder];
      if (null == item) return;
      Node prev = null;
      do
      {
        if (item.Key == key)
        {
          if (null != prev)
          {
            prev.Next = item.Next;
          }
          else
          {
            _data[remainder] = item.Next;
          }
          return;
        }
        prev = item;
        item = item.Next;
      }
      while (item.Next != null);

    }

    private class Node
    {
      public Node(int key, int value)
      {
        Key = Key;
        Value = value;
      }
      public int Key { get; set; }
      public int Value { get; set; }
      public Node Next { get; set; }
    }
  }

}