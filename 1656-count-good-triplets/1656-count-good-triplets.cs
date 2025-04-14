public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) 
    {
        int ans = 0;
        for (int i = 0; i < arr.Length-2; i++)
        {
            for (int j = i+1; j < arr.Length-1; j++)
            {
                for (int k = j+1; k < arr.Length; k++)
                {
                    int x = Math.Abs(arr[i] - arr[j]);
                    int y = Math.Abs(arr[j] - arr[k]);
                    int z = Math.Abs(arr[k] - arr[i]);

                    if (x <= a && y <= b && z <= c)
                        ans++;
                }
            }
        }

        return ans;
    }
}