public class Solution {
    public int BuyChoco(int[] p, int m) 
    {
        int mi1 = int.MaxValue, mi2 = int.MaxValue;
        for (int i = 0; i < p.Length; i++)
        {
            if (mi1 >= p[i])
            {
                mi2 = mi1;
                mi1 = p[i];
            }
            else if (mi2 > p[i]) mi2 = p[i];
        }
        return mi1+mi2 <= m ? m-(mi1+mi2) : m;
    }
}