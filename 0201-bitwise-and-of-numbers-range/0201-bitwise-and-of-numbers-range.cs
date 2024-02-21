public class Solution {
    public int RangeBitwiseAnd(int n, int m) 
    {
        int c = 0;
        while(n != m)
        {
            n >>= 1;
            m >>= 1;
            c++;
        }
        n <<= c;
        return n;
    }
}