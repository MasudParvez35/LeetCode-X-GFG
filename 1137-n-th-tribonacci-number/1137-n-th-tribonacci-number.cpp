class Solution {
public:
    int dp[40];
    int fun(int n) {
        if (n <= 1) return dp[n] = n;
        if (n == 2) return dp[2] = 1;
        if (dp[n] != -1) return dp[n];
        return dp[n] = fun(n-1) + fun(n-2) + fun(n-3);
    }
    int tribonacci(int n) {
        memset(dp, -1, sizeof(dp));
        return fun(n);
    }
};