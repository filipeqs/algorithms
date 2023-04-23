/*
Write a function called maxSubarraySum which accepts
an array of integers and a number called n. The function
should calculate the maximum sum of n consecutive elements 
the array.

maxSubarraySum([1,2,5,2,8,1,5],2) // 10
maxSubarraySum([1,2,5,2,8,1,5],4) // 17
maxSubarraySum([4,2,1,6],1) // 6
maxSubarraySum([4,2,1,6,2],4) // 13
maxSubarraySum([],4) // null
*/

function maxSubarraySum(arr, n) {
    if (arr.length === 0) return null;

    let result = 0;
    for (let i = 0; i < n; i++) {
        result += arr[i];
    }

    let tempResult = result;
    for (let i = 1; i <= arr.length - n; i++) {
        tempResult -= arr[i - 1];
        tempResult += arr[i + n - 1];
        if (tempResult > result) result = tempResult;
    }

    return result;
}

console.log(maxSubarraySum([1, 2, 5, 2, 8, 1, 5], 2));
console.log(maxSubarraySum([1, 2, 5, 2, 8, 1, 5], 4));
console.log(maxSubarraySum([4, 2, 1, 6], 1));
console.log(maxSubarraySum([4, 2, 1, 6, 2], 4));
console.log(maxSubarraySum([], 4));
