/*
 * @lc app=leetcode id=235 lang=csharp
 *
 * [235] Lowest Common Ancestor of a Binary Search Tree
 */

using System.Collections.Generic;
using Leetcode.fundament;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int x) { val = x; }
* }
*/
public class Solution
{
  public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
  {
    var set = new HashSet<TreeNode>(){p};
    var s = new HashSet<TreeNode>(){q};
    FindAncestor(root, p.val, set);
    FindAncestor(root, q.val, s);
    foreach (var item in s)
    {
      if (set.Contains(item)) return item;
    }
    return null;
  }

  private bool FindAncestor(TreeNode node, int target, HashSet<TreeNode> set)
  {
    if (node == null) return false;
    if (node.val == target) return true;
    if (FindAncestor(node.left, target, set) || FindAncestor(node.right, target, set))
    {
      set.Add(node);
      return true;
    }
    return false;
  }
}

