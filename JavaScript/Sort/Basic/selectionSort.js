function selectionSort(arr) {
  for (let i = 0; i < arr.length; i++) {
    let lowestIndex = i;
    for (let j = i; j < arr.length; j++) {
      if (arr[j] < arr[lowestIndex]) {
        lowest = arr[j];
        lowestIndex = j;
      }
    }

    swap(arr, i, lowestIndex);
  }

  return arr;
}

function swap(arr, i, j) {
  const temp = arr[i];
  arr[i] = arr[j];
  arr[j] = temp;
}

console.log(selectionSort([5, 3, 4, 1, 2]));

// [5, 3, 4, 1, 2]
// [1, 3, 4, 5, 2]
// [1, 2, 4, 5, 3]
// [1, 2, 3, 5, 4]
// [1, 2, 3, 4, 5]
