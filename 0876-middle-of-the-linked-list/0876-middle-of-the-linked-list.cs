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
    public ListNode MiddleNode(ListNode head) 
    {
        int c = 0;
        ListNode tmp = head;
        while(tmp != null) {
            c++;
            tmp = tmp.next;
        }
        tmp = head;
        c /= 2;
        for (int i = 0; i < c; i++) {
            tmp = tmp.next;
        }
        return tmp;
    }
}