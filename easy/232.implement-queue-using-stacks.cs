/*
 * @lc app=leetcode id=232 lang=csharp
 *
 * [232] Implement Queue using Stacks
 */
using System.Collections.Generic;

public class MyQueue {

    private  LinkedList<int> _data;
    /** Initialize your data structure here. */
    public MyQueue() {
        _data = new LinkedList<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        _data.AddLast(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        var x = _data.First;
        _data.RemoveFirst();
        return x.Value;
    }
    
    /** Get the front element. */
    public int Peek() {
        return _data.First.Value;
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return _data.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */

