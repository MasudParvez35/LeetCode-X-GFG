class Solution {
public:
    vector<int> productExceptSelf(vector<int>& a) 
    {
        int n = a.size(), c = 0, f = 1;
        vector <int> ans(n);
        for(int i : a) {
            if (i == 0) c++;
            f *= i;
        }
        if (c > 1) return ans;
        if (c == 1) {
            int f = 1, ind = -1;
            for (int i = 0; i < n; i++) {
                if (a[i] == 0) {
                    ind = i;
                }
                else f *= a[i];
            }
            ans[ind] = f;
            return ans;
        }
        for (int i = 0; i < n; i++) {
            ans[i] = f / a[i];
        }
        return ans;
    }
};