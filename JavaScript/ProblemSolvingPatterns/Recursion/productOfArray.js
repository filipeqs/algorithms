/*
Write a function called productOfArray which takes in an 
array of numbers and returns the product of them all.
*/

function productOfArray(arr) {
  if (arr.length === 0) return 1;

  const value = arr[arr.length - 1];
  arr.pop();
  return value * productOfArray(arr);
}

console.log(productOfArray([1, 4, 6]));
