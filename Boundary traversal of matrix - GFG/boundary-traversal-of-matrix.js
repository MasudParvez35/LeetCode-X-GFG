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
        
        input_line = readLine().split(' ');
        let matrix = new Array(n);
        for(let i=0;i<n;i++)
        {
            let a = new Array(m);
            for(let j=0;j<m;j++)
            {
                a[j] =parseInt(input_line[i*m+j]);
            }
            matrix[i] = a;
        }
        
        let obj = new Solution();
        let ans = obj.boundaryTraversal(matrix, n, m);
        let s = "";
        for(let i = 0 ; i < ans.length ;i++)
        {
            if(ans[i]==-0)
                ans[i]=0;
            s+=ans[i];
            s+=" ";
        }
        console.log(s);
    }
}
// } Driver Code Ends


//User function Template for javascript

class Solution 
{
    boundaryTraversal(a, n, m)
    {
        let v = [];
        for (let i = 0; i < m; i++) v.push(a[0][i]);
        for (let i = 1; i < n; i++) v.push(a[i][m-1]);
        if (n > 1) for (let i = m-2; i >= 0; i--) v.push(a[n-1][i]);
        if (m > 1) for (let i = n-2; i > 0; i--) v.push(a[i][0]);
        return v;
    }
}