function search(arr, n) {
    let left = 0;
    let right = arr.length;

    while (left <= right) {
        const middle = Math.floor((left + right) / 2);
        if (arr[middle] === n) return middle;

        if (arr[middle] <= n) left = middle + 1;
        else right = middle - 1;
    }

    return -1;
}

search([1, 4, 5, 7, 8, 9], 10);
