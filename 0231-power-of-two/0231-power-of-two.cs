public class Solution {
    public bool ok(int n)
    {
        while(n > 1)
        {
            if (n % 2 == 1) return false;
            n /= 2;
        }
        return true;
    }
    public bool IsPowerOfTwo(int n) {
        if (n < 1) return false;
        return ok(n);
    }
}