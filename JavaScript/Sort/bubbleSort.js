function bubbleSort(arr) {
  for (let i = arr.length; i >= 0; i--) {
    for (let j = 0; j < i - 1; j++) {
      const current = arr[j];
      const next = arr[j + 1];

      if (current > next) {
        arr[j] = next;
        arr[j + 1] = current;
      }
    }
  }

  return arr;
}

console.log(bubbleSort([5, 3, 4, 1, 2]));

// [5, 3, 4, 1, 2]
// [3, 4, 1, 2, 5]
// [4, 1, 2, 3, 5]
// [1, 2, 3, 4, 5]
