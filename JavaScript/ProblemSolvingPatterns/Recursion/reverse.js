/*
Write a recursive function called reverse which 
accepts a string and returns a new string in reverse.
*/

function recursive(input) {
  if (input.length === 0) return '';

  const letter = input[input.length - 1];
  const newInput = input.substring(0, input.length - 1);
  return letter + recursive(newInput);
}

console.log(recursive('test'));
