//{ Driver Code Starts
//Initial Template for javascript
'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function main() {
    let t = parseInt(readLine());
    for(let i=0;i<t;i++)
    {
        let input_line = readLine().split(' ');
        let n = parseInt(input_line[0]);
        let m = parseInt(input_line[1]);
        
        let matrix = new Array(n);
        for(let i=0;i<n;i++)
        {
            input_line = readLine().split(' ');
            let a = new Array(m);
            for(let j=0;j<m;j++)
            {
                a[j] =parseInt(input_line[j]);
            }
            matrix[i] = a;
        }
      
        let obj = new Solution();
        let ans = obj.booleanMatrix(matrix);
        for(let i = 0 ; i < n ;i++)
        {
            let s = "";
            for(let j = 0; j < m; j++)
            {
                s+=matrix[i][j];
                s+=" ";   
            }
            console.log(s);
        }
    }
}
// } Driver Code Ends


//User function Template for javascript


/**
 * @param {number[][]} matrix
*/
class Solution 
{
    //Function to modify the matrix such that if a matrix cell matrix[i][j]
    //is 1 then all the cells in its ith row and jth column will become 1.
    booleanMatrix(v)
    {
        let n = v.length, m = v[0].length;
        let row = new Array(n+1).fill(0);
        let col = new Array(m+1).fill(0);
        //let[] row = new let[n+1];
        //let[] col = new let[m+1];

        for (let i = 0; i < n; i++)
        {
            for (let j = 0; j < m; j++)
            {
                if (v[i][j] == 1)
                {
                    row[i] = 1;
                    col[j] = 1;
                }
            }
        }

        for (let i = 0; i < n; i++)
        {
            for (let j = 0; j < m; j++)
            {
                if (row[i] == 1 || col[j] == 1)
                {
                    v[i][j] = 1;
                }
            }
        }
    }
}
