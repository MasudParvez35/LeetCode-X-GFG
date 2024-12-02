class Solution {
public:
    int isPrefixOfWord(string sentence, string searchWord)
    {
        int cnt = 1;
        sentence = " " + sentence;
        for (int i = 1; i <= sentence.size()-searchWord.size(); i++)
        {
            if (sentence[i] == ' ')
                cnt++;
            if (sentence[i] == searchWord[0] && sentence[i-1] == ' ')
            {
                bool f = true;
                for (int j = 0; j < searchWord.size(); j++)
                {
                    if (sentence[i+j] != searchWord[j])
                        f = false;
                }
                if (f)
                    return cnt;
            }
        }
        return -1;
    }
};