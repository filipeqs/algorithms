/*
Given a sorted array of integers, write a function called search, 
that accepts a value and returns the index where the value passed 
to the function is located. If the value is not found, return -1

search([1,2,3,4,5,6],4) // 3
search([1,2,3,4,5,6],6) // 5
search([1,2,3,4,5,6],11) // -1
*/

function search(arr, n) {
    if (arr.length === 0) return -1;

    let left = 0;
    let right = arr.length - 1;

    while (left <= right) {
        const middle = Math.floor((left + right) / 2);
        const value = arr[middle];
        if (value === n) return middle;

        if (value < n) left = middle + 1;
        else right = middle - 1;
    }

    return -1;
}

console.log(search([1, 2, 3, 4, 5, 6], 4));
console.log(search([1, 2, 3, 4, 5, 6], 6));
console.log(search([1, 2, 3, 4, 5, 6], 11));
