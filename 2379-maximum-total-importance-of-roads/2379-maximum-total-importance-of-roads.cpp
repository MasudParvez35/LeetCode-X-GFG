class Solution {
public:
    long long maximumImportance(int n, vector<vector<int>>& a) 
    {
        long long ans = 0;
        vector<long long> v(n,0);
        for(int i = 0; i < a.size(); i++) 
        {
            v[a[i][0]]++;
            v[a[i][1]]++;
        }
        sort(v.begin(), v.end());
        
        for (int i = 0; i < n; i++) {
            ans += (v[i]*(i+1));
        }
        return ans;
    }
};