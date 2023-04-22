/*
Write a function called maxSubarraySum which accepts
an array of integers and a number callen n. The function
should calculate the maximum sum of n consecutive elements 
the array.

maxSubarraySum([1,2,5,2,8,1,5],2) // 10
maxSubarraySum([1,2,5,2,8,1,5],4) // 17
maxSubarraySum([4,2,1,6],1) // 6
maxSubarraySum([4,2,1,6,2],4) // 13
maxSubarraySum([],4) // null
*/

int? MaxSubarraySum(int[] arr, int n) 
{
    if (arr.Length == 0) return null;

    var result = 0;
    for (int i = 0; i < n; i++)
        result += arr[i];

    var tempResult = result;
    for (int i = 1; i <= arr.Length - n; i++)
    {
        tempResult -= arr[i-1];
        tempResult += arr[i + n - 1];
        if (tempResult > result)
            result = tempResult;
    }

    return result;
}

Console.WriteLine(MaxSubarraySum(new int[] {1,2,5,2,8,1,5}, 2));
Console.WriteLine(MaxSubarraySum(new int[] {1,2,5,2,8,1,5}, 4));
Console.WriteLine(MaxSubarraySum(new int[] {4,2,1,6}, 1));
Console.WriteLine(MaxSubarraySum(new int[] {4,2,1,6,2}, 4));
Console.WriteLine(MaxSubarraySum(new int[] {}, 4));
