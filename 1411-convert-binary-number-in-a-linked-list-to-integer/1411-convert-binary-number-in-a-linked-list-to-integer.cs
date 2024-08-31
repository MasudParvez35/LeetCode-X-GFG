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
    public int GetDecimalValue(ListNode head) 
    {
        int ans = 0;
        while(head != null)
        {
            ans = ans*2 + head.val;
            head = head.next;
        }
        return ans;
    }
}