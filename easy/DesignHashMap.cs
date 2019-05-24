namespace Leetcode.easy
{
  public class DesignHashMap
  {
    private int[] _data;
    /** Initialize your data structure here. */
    public DesignHashMap()
    {
      _data = new int[1000001];
      for (int i = 0; i < _data.Length; i++)
      {
        _data[i] = -1;
      }
    }

    /** value will always be non-negative. */
    public void Put(int key, int value)
    {
      _data[key] = value;
    }

    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key)
    {
      return _data[key];
    }

    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key)
    {
      _data[key] = -1;
    }
  }
}