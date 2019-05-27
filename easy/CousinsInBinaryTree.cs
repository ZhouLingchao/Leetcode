using System;
using Leetcode.fundament;

namespace Leetcode.easy
{
  public class CousinsInBinaryTree
  {
    public bool IsCousins(TreeNode root, int x, int y)
    {
      var xTuple = Find(-1, root, x, 0);
      var yTuple = Find(-1, root, y, 0);
      if (xTuple.Item1 == yTuple.Item1 && xTuple.Item2 != yTuple.Item2) return true;
      return false;
    }

    private Tuple<int, int> Find(int parentValue, TreeNode node, int target, int depth)
    {
      if (node == null) return null;
      if (node.val == target) return Tuple.Create(depth, parentValue);
      else
      {
        depth++;
        var left = Find(node.val, node.left, target, depth);
        if (left != null) return left;
        var right = Find(node.val, node.right, target, depth);
        if (right != null) return right;
      }
      return null;
    }
  }
}