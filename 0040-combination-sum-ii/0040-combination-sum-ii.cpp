class Solution {
public:
    vector<vector<int>> ans;
    void solve(vector<int>&a, int t, int i, int sm, vector<int>&v)
    {
        if (sm == t) {
            ans.push_back(v); return;
        }
        if (i >= a.size() or sm > t) return;
        v.push_back(a[i]);
        solve(a, t, i+1, sm+a[i], v);
        v.pop_back();
        while(i < a.size()-1 and a[i] == a[i+1]) i++;
        solve(a, t, i+1, sm, v);
    }
    vector<vector<int>> combinationSum2(vector<int>& a, int t) 
    {
        sort(a.begin(), a.end());
        vector <int> v;
        solve(a,t,0,0,v);
        return ans;
    }
};