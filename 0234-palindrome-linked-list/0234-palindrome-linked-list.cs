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
    public bool IsPalindrome(ListNode head) 
    {
        List<int> v = new List<int>();
        while(head != null)
        {
            v.Add(head.val);
            head = head.next;
        }
        int l = 0, r = v.Count()-1;
        while(l < r)
        {
            if (v[l++] != v[r--]) return false;
        }
        return true;
    }
}