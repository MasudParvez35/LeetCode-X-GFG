public class Solution {
    public IList<string> StringMatching(string[] words) 
    {
        Array.Sort(words);
        List<string> ans = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (i == j)
                    continue;
                    
                bool isFind = words[j].Contains(words[i]);
                if (isFind) {
                    ans.Add(words[i]);
                    break;
                }
            }
        }
        return ans;
    }
}