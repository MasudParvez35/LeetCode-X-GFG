public class Solution {
    public IList<int> StableMountains(int[] height, int threshold) 
    {
        IList<int> ans = new List<int>();
        for (int i = 0; i < height.Length-1; i++)
        {
            if (height[i] > threshold)
            {
                ans.Add(i+1);
            }
        }
        return ans;
    }
}