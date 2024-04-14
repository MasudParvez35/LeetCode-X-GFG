public class Solution {
    bool[] prime = new bool[105];
    void Sieve()
    {
        prime[1] = true;
        for (int i = 2; i * i <= 100; i++)
        {
            if (!prime[i])
            {
                for (int j = 2 * i; j <= 100; j += i)
                {
                    prime[j] = true;
                }
            }
        }
    }
    public int MaximumPrimeDifference(int[] a) 
    {
        Sieve();
        int x = -1, y = -1;
        for (int i = 0; i < a.Length; i++)
        {
            if (!prime[a[i]])
            {
                if (x == -1)
                {
                    x = i;
                    y = i;
                }
                else
                {
                    y = i;
                }
            }
        }
        return y - x;
    }
}