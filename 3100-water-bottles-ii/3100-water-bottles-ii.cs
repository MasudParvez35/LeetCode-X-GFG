public class Solution {
    public int MaxBottlesDrunk(int a, int ex) 
    {
        int ans = a, fb = 0, eb = a;
        while(true)
        {
            if (fb + eb < ex) {
                ans += fb; break;
            }
            if (eb >= ex)
            {
                eb -= ex;
                ex++;
                fb++;
            }
            else {
                ans += fb;
                eb += fb;
                fb = 0;
            }
        }
        return ans;
    }
}