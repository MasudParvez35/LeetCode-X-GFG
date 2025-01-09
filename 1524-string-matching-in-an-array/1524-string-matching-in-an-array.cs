public class Solution {
    public IList<string> StringMatching(string[] words) 
    {
        List<string> ans = new List<string>();
        Array.Sort(words, (a, b) => {
            return a.Length.CompareTo(b.Length);
        });
        for (int i = 0; i < words.Length-1; i++)
        {
            for (int j = i+1; j < words.Length; j++)
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