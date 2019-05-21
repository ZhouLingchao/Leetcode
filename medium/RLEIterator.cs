
namespace Leetcode.medium
{
  public class RLEIterator
  {
    private int[] _data;
    private int _index;
    private int _used;
    private long _count;
    private long _current;
    public RLEIterator(int[] A)
    {
      _data = A;
      for (int i = 0; i < A.Length; i += 2)
      {
        _count += A[i];
      }
    }
    public int Next(int n)
    {
      _current += n;
      if (_current >= _count) return -1;

      int result = 0;
      while (n >= 0)
      {
        if (n + _used >= _data[_index])
        {
          n -= (_data[_index] - _used);
          _used = 0;
          _index += 2;
          if (n == 0) return _data[_index - 1];
        }
        else
        {
          _used += n;
          result = _data[_index + 1];
          break;
        }
      }
      return result;
    }
  }
}
