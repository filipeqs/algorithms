function pivot(arr, start = 0, end = arr.length) {
  const pivot = arr[start];
  let pivotIndex = start;

  for (let i = start; i < end; i++) {
    if (pivot > arr[i]) {
      pivotIndex++;
      swap(arr, pivotIndex, i);
    }
  }

  swap(arr, start, pivotIndex);

  return pivotIndex;
}

function swap(arr, i, j) {
  const temp = arr[i];
  arr[i] = arr[j];
  arr[j] = temp;
}

function quickSort(arr, start = 0, end = arr.length) {
  if (end - start < 2) return arr;

  const pivotIndex = pivot(arr, start, end);
  quickSort(arr, start, pivotIndex - 1);
  quickSort(arr, pivotIndex + 1, end);

  return arr;
}

console.log(quickSort([5, 2, 1, 8, 4, 7, 6, 3]));
