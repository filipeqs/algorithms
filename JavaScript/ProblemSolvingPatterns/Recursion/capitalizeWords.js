/*
Write a recursive function called capitalizeWords. 
Given an array of words, return a new array containing 
each word capitalized.

let words = ['i', 'am', 'learning', 'recursion'];
*/

function capitalizeWords(arr) {
  if (arr.length === 0) return [];

  const value = arr[0].toUpperCase();
  arr.shift();
  return [value, ...capitalizeWords(arr)];
}

console.log(capitalizeWords(['i', 'am', 'learning', 'recursion']));
