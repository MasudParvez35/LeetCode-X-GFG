//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                var stringArray = Console.ReadLine().Split(' ');
                int n = int.Parse(stringArray[0]);
                int m = int.Parse(stringArray[1]);
                List<List<int>> A = new List<List<int>>();
                for (int i = 0; i < n * m; i += m)
                {
                    List<int> row = new List<int>();
                    stringArray = Console.ReadLine().Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        row.Add(int.Parse(stringArray[j]));
                    }
                    A.Add(row);
                }
                
                Solution obj = new Solution();
                obj.booleanMatrix(A);
                foreach(var row in A){
                    foreach(int i in row){
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
        }


    }

    
// } Driver Code Ends
//User function Template for C#

    class Solution
    {
        public void booleanMatrix(List<List<int>> v)
        {
           int m = v.Count;
            int n = v[0].Count;
            int[] R = new int[m];
            int[] C = new int[n];
    
            // Initialize R and C arrays
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (v[i][j] == 1)
                    {
                        R[i] = 1;
                        C[j] = 1;
                    }
                }
            }
    
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (R[i] == 1 || C[j] == 1)
                    {
                        v[i][j] = 1;
                    }
                }
            }
        }
    }
}

//{ Driver Code Starts.
// } Driver Code Ends