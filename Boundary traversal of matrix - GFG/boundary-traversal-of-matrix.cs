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
                stringArray = Console.ReadLine().Split(' ');
                List<List<int>> A = new List<List<int>>();
                for (int i = 0; i < n * m; i += m)
                {
                    List<int> row = new List<int>();
                    for (int j = 0; j < m; j++)
                    {
                        row.Add(int.Parse(stringArray[i + j]));
                    }
                    A.Add(row);
                }
                Solution obj = new Solution();
                var res = obj.boundaryTraversal(A,n,m);
                foreach(int i in res){
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }

    
// } Driver Code Ends
//User function Template for C#

    class Solution
    {
        //Function to return list of integers that form the boundary 
        //traversal of the matrix in a clockwise manner.
        public List<int> boundaryTraversal(List<List<int>> a, int n, int m)
        {
            List<int> v = new List<int>();
            for (int i = 0; i < m; i++) v.Add(a[0][i]);
            for (int i = 1; i < n; i++) v.Add(a[i][m-1]);
            if (n > 1) for (int i = m-2; i >= 0; i--) v.Add(a[n-1][i]);
            if (m > 1) for (int i = n-2; i > 0; i--) v.Add(a[i][0]);
            return v;
        }
    }
}

//{ Driver Code Starts.
// } Driver Code Ends