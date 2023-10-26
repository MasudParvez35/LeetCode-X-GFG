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
    let i = 0;
    for(;i<t;i++)
    {
        let n = parseInt(readLine());
        let obj = new Solution();
        let res = obj.minOperation(n);
        if(res === -0)
            res = 0;
        console.log(res);
    }
}

// } Driver Code Ends


//User function Template for javascript


/**
 * @param {number} n
 * @return {number}
*/

class Solution {

    minOperation(n)
    {
        let c = 0;
        while(n > 0)
        {
            if (n % 2 == 0) n /= 2;
            else n--;
            c++;
        }
        return c;
    }
}