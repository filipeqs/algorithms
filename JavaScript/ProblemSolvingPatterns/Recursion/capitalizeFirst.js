/*
Write a recursive function called capitalizeFirst. 
Given an array of strings, capitalize the first 
letter of each string in the array.

capitalizeFirst(['car','taco','banana']); // ['Car','Taco','Banana']
*/

function capitalizeFirst(arr) {
  if (arr.length === 0) return [];

  const value = arr[0];
  arr.shift();
  return [capitalizeFirstLetter(value), ...capitalizeFirst(arr)];
}

function capitalizeFirstLetter(string) {
  return string.charAt(0).toUpperCase() + string.slice(1);
}

console.log(capitalizeFirst(['car', 'taco', 'banana']));
