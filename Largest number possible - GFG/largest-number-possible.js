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

function printList(res,n){
    let s="";
    for(let i=0;i<n;i++){
        s+=res[i];
        s+=" ";
    }
    console.log(s);
}


function main() {
    let t = parseInt(readLine());
    let i = 0;
    for(;i<t;i++)
    {
        let input_ar1 = readLine().split(' ').map(x=>parseInt(x));
        let n = input_ar1[0];
        let s = input_ar1[1];
        let obj = new Solution();
        let res = obj.findLargest(n, s);
        console.log(res);
        
    }
}// } Driver Code Ends



// } Driver Code Ends


//User function Template for javascript



/**
 * @param {number} n
 * @param {number} s
 * @returns {string}
*/

class Solution{
    findLargest(n,s)
    {
        if (s > n * 9 || (n > 1 && !s)) return "-1";
        let ans = "";
        for (let i = 9; i >= 0;) {
            while (s >= i) {
                ans += i.toString();
                s -= i;
                if (ans.length === n) return ans;
            }
            i--;
        }
        return ans;
    }
}


