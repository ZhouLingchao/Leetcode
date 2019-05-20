
using System.Collections.Generic;
using Leetcode.fundament;

namespace Leetcode.medium
{
  public class BinarySearchTreeToGreaterSumTree
  {
    public TreeNode BstToGst(TreeNode node)
    {
      var sum = 0;
      var orderedList = GetOrderedList(node);
      foreach(var orderedNode in orderedList){
        sum += orderedNode.val;
        orderedNode.val = sum;
      }
      return node;
    }

    private IList<TreeNode> GetOrderedList(TreeNode node){
      var list =  new List<TreeNode>();
      BuildList(list,node);
      return list;
    }
    private void BuildList(IList<TreeNode> list, TreeNode node){
      if(node == null) return ;
      BuildList(list,node.right);
      list.Add(node);
      BuildList(list,node.left);
    }
  }
}