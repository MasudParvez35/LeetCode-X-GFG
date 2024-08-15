class Solution {
public:
    vector<vector<int>> ans;
    void dfs(vector<int>&a, vector<int>&v, int i, int sm, int t)
    {
        if (sm == t) {
            ans.push_back(v);
            return;
        }
        if (i >= a.size() or sm > t) return;
        v.push_back(a[i]);
        dfs(a,v,i+1,sm+a[i],t);
        v.pop_back();
        while(i < a.size()-1 && a[i] == a[i+1]) i++;
        dfs(a,v,i+1,sm,t);
    }
    vector<vector<int>> combinationSum2(vector<int>& a, int t) 
    {
        sort(begin(a), end(a));
        vector <int> v;
        dfs(a,v,0,0,t);
        return ans;
    }
};