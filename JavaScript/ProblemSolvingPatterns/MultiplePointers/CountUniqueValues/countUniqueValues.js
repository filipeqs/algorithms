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

function countUniqueValues(input) {
    if (input.length === 0) return 0;

    let result = 1;
    let i = 0;

    for (let j = 0; j < input.length; j++) {
        if (input[i] !== input[j]) {
            result++;
            i = j;
        }
    }

    return result;
}

countUniqueValues([1, 1, 1, 1, 1, 2]);
countUniqueValues([1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13]);
countUniqueValues([]);
countUniqueValues([-2, -1, -1, 0, 1]);
