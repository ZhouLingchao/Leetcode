using Leetcode.fundament;

namespace Leetcode.easy
{
  public class UnivaluedBinaryTree
  {
    public bool IsUnivalTree(TreeNode root)
    {
      if (root.left != null)
      {
        if (root.left.val != root.val || !IsUnivalTree(root.left)) return false;
      }
      if (root.right != null)
      {
        if (root.right.val != root.val || !IsUnivalTree(root.right)) return false;
      }
      return true;
    }
  }
}