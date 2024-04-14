class Solution {
public:
    long long numberOfSubarrays(vector<int>& a) 
    {
        int n = a.size();
        map<int, int> mp;
        long long ans = n;
        for (int i = 0; i < n; i++) 
        {
            int x = a[i];
            ans += mp[x];
            for (auto it : mp) 
            {
                if (it.first < x) mp.erase(it.first);
                else break;
            }
            mp[x]++;
        }
        return ans;
    }
};