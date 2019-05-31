/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
 */

using System.Collections.Generic;
using System.Text;
using Leetcode.fundament;
/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int x) { val = x; }
* }
*/
public class Solution
{
  public bool IsPalindrome(ListNode head)
  {
    if(null==head) return true;
    var stack = new Stack<int>();
    var curr = head;
    while(null!=curr){
        stack.Push(curr.val);
        curr= curr.next;
    }
    var loopCount = stack.Count / 2;
    for (int i = 0; i <loopCount ; i++)
    {
        if(stack.Pop() != head.val) return false;
        head = head.next;
    }
    return true;
  }
}

