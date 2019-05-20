using System.Collections.Generic;
using Leetcode.fundament;

namespace Leetcode.medium
{
  /*
    this is not a good soulution 
   */
  public class ConstructBinarySearchTreeFromPreorderTraversal
  {
    public TreeNode BstFromPreorder(int[] preorder)
    {
      var root = new TreeNode(preorder[0]);
      for (var i = 1; i < preorder.Length; i++)
      {
        Location(root, preorder[i]);
      }
      return root;
    }
    private void Location(TreeNode node, int value)
    {
      if (value > node.val)
      {
        if (node.right == null) node.right = new TreeNode(value);
        else Location(node.right, value);
      }
      else
      {
        if (node.left == null) node.left = new TreeNode(value);
        else Location(node.left, value);
      }
    }
  }
}