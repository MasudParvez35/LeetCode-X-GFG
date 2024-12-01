public class Solution {
    public bool IsExist(int[] arr, int value)
    {
        int left = 0, right = arr.Length-1;
        while(left <= right)
        {
            int mid = (left + right)/2;
            if (arr[mid] == value)
                return true;
            if (arr[mid] > value)
                right = mid-1;
            else 
                left = mid+1;
        }
        return false;
    }
    public bool CheckIfExist(int[] arr) 
    {
        Array.Sort(arr);
        int zero = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index] == 0)
            {
                zero++;
                continue;
            }
            int value = arr[index]*2;
            if (IsExist(arr, value))
                return true;
        }
        Console.WriteLine(zero);
        return zero >= 2 ? true : false;
    }
}