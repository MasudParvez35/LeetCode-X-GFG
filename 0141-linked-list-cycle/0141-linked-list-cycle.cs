/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) 
    {
        while(head != null)
        {
            if (head.val == int.MaxValue) return true;
            head.val = int.MaxValue;
            head = head.next;
        }
        return false;    
    }
}