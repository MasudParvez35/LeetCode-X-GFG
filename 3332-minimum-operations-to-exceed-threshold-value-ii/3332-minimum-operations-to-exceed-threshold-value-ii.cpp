class Solution {
public:
    int minOperations(vector<int>& nums, int k) 
    {
        priority_queue <long, vector<long>, greater<long>> q;
        int ans = 0;
        for (int i : nums) 
            q.push(i);
        
        while(q.size() > 1)
        {
            long first = q.top();
            q.pop();
            if (first >= k)
                break;
            long second = q.top();
            q.pop();
            long newNumber = first*2 + second;
            q.push(newNumber);
            ans++;
        }
        return ans;
    }
};