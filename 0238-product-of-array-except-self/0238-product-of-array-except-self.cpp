class Solution {
public:
    vector<int> productExceptSelf(vector<int>& a) 
    {
        int n = a.size(), zero = 0, mul = 1;
        vector <int> ans(n, 0);
        
        for (int i = 0; i < n; i++) 
        {
            zero += a[i] == 0;
            if (a[i] != 0) mul *= a[i];
        }
        
        if (zero > 1)
            return ans;
        if (zero == 1) {

            for (int i = 0; i < n; i++) {
                if (a[i] == 0) 
                    ans[i] = mul;
            }
            return ans;
        }
        for (int i = 0; i < n; i++) {
            ans[i] = mul / a[i];
        }
        return ans;
    }
};