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
public class Solution 
{
    public bool IsFind(int[] nums, int val) 
    {
        int l = 0, r = nums.Length - 1;
        while (l <= r) 
        {
            int mid = (l + r) / 2;
            if (nums[mid] == val) 
                return true;
            if (nums[mid] > val) 
                r = mid - 1;
            else 
                l = mid + 1;
        }
        return false;
    }

    public ListNode ModifiedList(int[] nums, ListNode head) 
    {
        Array.Sort(nums); 
        ListNode tmp = new ListNode(-1); 
        ListNode dummy = tmp; 

        while (head != null) 
        {
            bool found = IsFind(nums, head.val);
            if (!found) 
            {
                tmp.next = head;
                tmp = tmp.next;
            }
            head = head.next;
        }
        tmp.next = null; 
        return dummy.next; 
    }
}
