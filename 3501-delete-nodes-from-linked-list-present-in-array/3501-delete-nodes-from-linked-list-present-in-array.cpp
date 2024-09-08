/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    bool isFind(vector<int>&nums, int val)
    {
        int l = 0, r = nums.size()-1;
        while(l <= r)
        {
            int mid = (l+r)/2;
            if (nums[mid] == val) 
                return true;
            if (nums[mid] > val) 
                r = mid-1;
            else 
                l = mid+1;
        }
        return false;
    }
    ListNode* modifiedList(vector<int>& nums, ListNode* head) 
    {
        sort(begin(nums), end(nums));
        ListNode *tmp = new ListNode(-1);
        ListNode *dummy = tmp;
        while(head)
        {
            bool f = isFind(nums, head->val);
            if (!f) {
                tmp->next = head;
                tmp = tmp->next;
            }
            head = head->next;
        }
        tmp->next = NULL;
        return dummy->next;
    }
};