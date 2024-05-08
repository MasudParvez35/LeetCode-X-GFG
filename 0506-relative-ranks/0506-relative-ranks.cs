public class Solution {
    public string[] FindRelativeRanks(int[] v) 
    {
        var vDict = new Dictionary<int,int>();
        for(int i = 0; i<v.Length;i++){
            vDict[v[i]] = i;
        }
        Array.Sort(v,(x,y)=>y.CompareTo(x));
        string[] result = new string[v.Length];
        for(int i = 0;i<v.Length;i++){
            if(i == 0){
                result[vDict[v[i]]] = "Gold Medal";
            }
            else if(i == 1){
                result[vDict[v[i]]] = "Silver Medal";
            }
            else if(i == 2){
                result[vDict[v[i]]] = "Bronze Medal";
            }
            else{
                result[vDict[v[i]]] = (i+1).ToString();
            }
        }
        return result;
    }
}