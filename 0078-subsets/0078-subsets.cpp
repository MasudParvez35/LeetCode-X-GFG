class Solution {
public:
    vector<vector<int>> ans;
    void dfs(vector<int>&a, vector<int>v, int i, int n)
    {
        if (i >= n) {
            ans.push_back(v);
            return;
        }
        v.push_back(a[i]);
        dfs(a,v,i+1,n);
        v.pop_back();
        dfs(a,v,i+1,n);
    }
    vector<vector<int>> subsets(vector<int>& a) 
    {
        int n = a.size();
        vector <int> v;
        dfs(a,v,0,n);
        return ans;
    }
};