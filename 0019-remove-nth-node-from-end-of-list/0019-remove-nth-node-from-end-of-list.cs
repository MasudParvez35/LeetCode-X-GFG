/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        int c = 0;
        ListNode tmp = head;
        while(tmp != null) {
            c++;
            tmp = tmp.next;
        }
        if (c == 1) return null;
        if (c == n) return head.next;
        int len = c - n;
        tmp = head;
        for (int i = 1; i < len; i++)
        {
            tmp = tmp.next;
        }
        tmp.next = tmp.next.next;
        return head;
    }
}