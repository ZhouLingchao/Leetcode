using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.fundament;

namespace Leetcode.easy
{
  public class SumOfRootToLeafBinaryNumbers
  {
    public int SumRootToLeaf(TreeNode root)
    {
        var list = new List<string>();
        Build(list, root, "");
        return list.Select(x=>Convert.ToInt32(x,2)).Sum();
    }

    private void Build(IList<string> list, TreeNode node, string s)
    {
      if (node.left == null && node.right == null) list.Add(s + node.val);
      else
      {
        if (node.left != null) Build(list, node.left, s + node.val);
        if (node.right != null) Build(list, node.right, s + node.val);
      }
    }
  }
}