public class Solution {
    public int MinimumRecolors(string blocks, int k) 
    {
        int ans = 0, black = 0;
        for (int i = 0, j = 0; i < blocks.Length; i++)
        {
            if (blocks[i] == 'B')
                black++;
            if (i-j+1 == k)
            {
                ans = Math.Max(ans, black);
                if (blocks[j] == 'B')
                    black--;
                j++;
            }
        }
        return k-ans;
    }
}