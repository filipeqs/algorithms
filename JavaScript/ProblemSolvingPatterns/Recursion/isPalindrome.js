/*
Write a recursive function called isPalindrome 
which returns true if the string passed to it is 
a palindrome (reads the same forward and backward). 
Otherwise it returns false.

// isPalindrome('awesome') // false
// isPalindrome('foobar') // false
// isPalindrome('tacocat') // true
// isPalindrome('amanaplanacanalpanama') // true
// isPalindrome('amanaplanacanalpandemonium') // false
*/

function isPalindrome(input) {
  if (input.length === 0) return '';

  const letter = input[input.length - 1];
  const newInput = input.substring(0, input.length - 1);
  const backward = letter + recursive(newInput);

  return backward === input;
}

console.log(isPalindrome('tat'));
