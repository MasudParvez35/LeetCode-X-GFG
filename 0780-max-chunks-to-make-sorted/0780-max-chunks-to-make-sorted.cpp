class Solution {
public:
    int maxChunksToSorted(vector<int>& a) 
    {
        int n = a.size(), ans = 0;
        for (int i = 0; i < n; i++)
        {
            int x = a[i], f = 0;
            vector <int> v;
            for (int j = 0; j <= i; j++)
            {
                v.push_back(a[j]);
            }
            sort(v.begin(), v.end());
            for (int i = 0; i < v.size(); i++) {
                if (v[i] != i) f = 1;
            }
            if (!f) ans++;
        }
        return ans;
    }
};