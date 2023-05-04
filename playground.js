function binarySearch(arr, n) {
  let i = 0;
  let j = arr.length;

  while (i <= j) {
    const middle = Math.floor((j + i) / 2);
    if (arr[middle] === n) return middle;

    if (n < arr[middle]) j = middle - 1;
    else i = middle + 1;
  }

  return undefined;
}

console.log(binarySearch([1, 2, 3, 4, 5, 6, 8, 10], 3));

function fib(n, memoize = []) {
  if (memoize[n]) return memoize[n];
  if (n <= 2) return 1;

  const res = fib(n - 1, memoize) + fib(n - 2, memoize);
  memoize[n] = res;
  return res;
}

console.log(fib(50));
