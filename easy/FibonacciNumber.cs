namespace Leetcode.easy
{
  public class FibonacciNumber
  {
    // Time complexity: O(2^n)
    public int Fib(int N)
    {
      if (N == 0) return 0;
      else if (N == 1) return 1;
      else return Fib(N - 1) + Fib(N - 2);
    }
    // Time complexity: o(n)
    public int Fib2(int N)
    {
      if (N <= 1) return N;
      int a = 0, b = 1;
      while (N-- > 1)
      {
        var sum = a + b;
        a = b;
        b = sum;
      }
      return b;
    }
  }
}