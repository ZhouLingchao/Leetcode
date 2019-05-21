namespace Leetcode.medium
{
  public class RLEIterator
  {
    private int[] _data;
    private int _count;
    private int _index;
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
      _index += n;
      if(_index > _data.Length) return -1;
      else return _data[_index-1];
    }
  }
}
