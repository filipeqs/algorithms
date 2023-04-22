/*
Multiple Pointers - countUniqueValues
Implement a function called countUniqueValues, 
which accepts a sorted array, and counts the unique 
values in the array. There can be negative numbers 
in the array, but it will always be sorted.

countUniqueValues([1,1,1,1,1,2]) // 2
countUniqueValues([1,2,3,4,4,4,7,7,12,12,13]) // 7
countUniqueValues([]) // 0
countUniqueValues([-2,-1,-1,0,1]) // 4
Time Complexity - O(n)

Space Complexity - O(n)

Bonus

You must do this with constant or O(1) space and O(n) time.
*/

int CountUniqueValues(int[] input) 
{
    if (input.Length == 0)
        return 0;

    var result = 1;
    var i = 0;
    
    for (int j = 0; j < input.Length; j++)
    {
        if (input[i] != input[j])
        {
            result++;
            i = j;
        }
    }

    return result;
}

Console.WriteLine(CountUniqueValues(new int[] {1,1,1,1,1,2}));
Console.WriteLine(CountUniqueValues(new int[] {1,2,3,4,4,4,7,7,12,12,13}));
Console.WriteLine(CountUniqueValues(new int[] {}));
Console.WriteLine(CountUniqueValues(new int[] {-2,-1,-1,0,1}));