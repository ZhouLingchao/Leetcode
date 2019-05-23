using Leetcode.fundament;

namespace Leetcode.easy
{
  public class TrimABinarySearchTree
  {
    // a good solution from Discuss in Leetcode
    // public TreeNode trimBST(TreeNode root, int L, int R)
    // {
    //   if (root == null) return null;

    //   if (root.val < L) return trimBST(root.right, L, R);
    //   if (root.val > R) return trimBST(root.left, L, R);

    //   root.left = trimBST(root.left, L, R);
    //   root.right = trimBST(root.right, L, R);

    //   return root;
    // }

    public TreeNode TrimBST(TreeNode root, int L, int R)
    {
      while (true)
      {
        if (root.val < L)
        {
          root = root.right;
        }
        else if (root.val > R)
        {
          root = root.left;
        }
        else break;
      }
      Trim(root, root.left, L, R);
      Trim(root, root.right, L, R);
      return root;
    }



    private void Trim(TreeNode parent, TreeNode current, int L, int R)
    {
      if (current == null) return;
      var val = current.val;
      if (val < L)
      {
        // remove left tree of current
        parent.left = current.right;
        current = current.right;
        Trim(parent, current, L, R);
      }
      else if (val > R)
      {
        parent.right = current.left;
        current = current.left;
        Trim(parent, current, L, R);
      }
      else
      {
        Trim(current, current.left, L, R);
        Trim(current, current.right, L, R);
      }
    }
  }
}