public class Solution {
    public int Sum(int n) {
        int sum = 0;
        while(n > 0) {
            sum += n%10;
            n /= 10;
        }
        return sum;
    }
    public int GetLucky(string s, int k) 
    {
        int sum = 0;
        foreach (char c in s)
        {
            int x = (c-'a')+1;
            sum += Sum(x);
        }
        for (int i = 1; i < k; i++) {
            sum = Sum(sum);
        }
        return sum;
    }
}