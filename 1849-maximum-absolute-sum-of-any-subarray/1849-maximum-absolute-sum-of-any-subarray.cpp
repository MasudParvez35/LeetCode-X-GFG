class Solution {
public:
    int sum(vector<int>& a) {
        int ans = 0, mi = 0;
        int ans1 = 0, mx = 0;
        for (int i = 0; i < a.size(); i++) {
            mi += a[i];
            if (mi < ans) ans = mi;
            if (mi > 0) mi = 0;
            
            mx += a[i];
            if (mx > ans1) ans1 = mx;
            if (mx < 0) mx = 0;
        }
        return max(-ans,ans1);
    }
    int maxAbsoluteSum(vector<int>& a) {
        int x = sum(a);
        return x;
    }
};