class Solution {
public:
    vector<vector<int>> insert(vector<vector<int>>& a, vector<int>& v) 
    {
        vector<vector<int>> ans;
        bool f = false;
        for (int i = 0; i < a.size(); i++)
        {
            if (a[i][0] < v[0] && a[i][1] < v[0]) {
                ans.push_back(a[i]);
            }
            else if (a[i][0] > v[1] && a[i][1] > v[1])
            {
                if (!f) {
                    ans.push_back(v);
                    f = true;
                }
                ans.push_back(a[i]);
            }
            else {
                v[0] = min(v[0], a[i][0]);
                v[1] = max(v[1], a[i][1]);
            }
        }
        if (!f) ans.push_back(v);
        return ans;
    }
};
