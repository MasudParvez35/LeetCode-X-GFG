class Solution {
public:
    int digit_sum(int n)
    {
        int sum = 0;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    int maximumSum(vector<int>& nums) 
    {
        map <int, vector<int>> mp;
        for (int i : nums) {
            mp[digit_sum(i)].push_back(i);
        }
        int ans = -1;
        for (auto it : mp)
        {
            vector <int> v = it.second;
            sort(v.rbegin(), v.rend());
            if (v.size() > 1)
                ans = max(ans, v[0]+v[1]);
        }
        return ans;
    }
};