/*
Write a function called minSubArrayLen which accepts two parameters - 
an array of positive integers and a positive integer.

This function should return the minimal length of a contiguous 
subarray of which the sum is greater than or equal to the integer 
passed to the function. If there isn't one, return 0 instead.

Examples:
minSubArrayLen([2,3,1,2,4,3], 7) // 2 -> because [4,3] is the smallest subarray
minSubArrayLen([2,1,6,5,4], 9) // 2 -> because [5,4] is the smallest subarray
minSubArrayLen([3,1,7,11,2,9,8,21,62,33,19], 52) // 1 -> because [62] is greater than 52
minSubArrayLen([1,4,16,22,5,7,8,9,10],39) // 3
minSubArrayLen([1,4,16,22,5,7,8,9,10],55) // 5
minSubArrayLen([4, 3, 3, 8, 1, 2, 3], 11) // 2
minSubArrayLen([1,4,16,22,5,7,8,9,10],95) // 0

Time Complexity - O(n)
Space Complexity - O(1)
*/

int MinSubArrayLen(int[] arr, int n) 
{
    var i = 0;
    var j = 0;
    var minIndex = int.MaxValue;
    var minTempIndex = 0;
    var sum = 0;

    while(i <= arr.Length) {
        if (sum >= n) 
        {
            if (minTempIndex < minIndex)
                minIndex = minTempIndex;

            if (i >= arr.Length)
                break;

            sum -= arr[i];
            minTempIndex--;
            i++;
        }
        else if (j < arr.Length)
        {
            sum += arr[j];
            j++;
            minTempIndex++;
        }
        else 
            break;
    }

    return minIndex == int.MaxValue ? 0 : minIndex;
}

Console.WriteLine(MinSubArrayLen(new int[] {2,3,1,2,4,3}, 7));
Console.WriteLine(MinSubArrayLen(new int[] {2,1,6,5,4}, 9));
Console.WriteLine(MinSubArrayLen(new int[] {3,1,7,11,2,9,8,21,62,33,19}, 52));
Console.WriteLine(MinSubArrayLen(new int[] {1,4,16,22,5,7,8,9,10}, 39));
Console.WriteLine(MinSubArrayLen(new int[] {1,4,16,22,5,7,8,9,10}, 55));
Console.WriteLine(MinSubArrayLen(new int[] {4, 3, 3, 8, 1, 2, 3}, 11));
Console.WriteLine(MinSubArrayLen(new int[] {1,4,16,22,5,7,8,9,10}, 95));