public class Solution {
    public string KthDistinct(string[] arr, int k) 
    {
        Dictionary<string,int> fre = new Dictionary<string,int>();
        foreach (var str in arr)
        {
            if (!fre.ContainsKey(str)) fre[str] = 1;
            else fre[str]++;
        }
        int count = 0;
        foreach (var str in arr)
        {
            if (fre[str] == 1)
            {
                count++;
                if (count == k) 
                    return str;
            }
        }

        return "";
    }
}