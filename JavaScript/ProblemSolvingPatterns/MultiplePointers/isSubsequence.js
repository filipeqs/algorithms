/*
Write a function called isSubsequence which takes in 
two strings and checks whether the characters in the 
first string form a subsequence of the characters in 
the second string. In other words, the function should 
check whether the characters in the first string appear 
somewhere in the second string, without their order changing.

Examples:
isSubsequence('hello', 'hello world'); // true
isSubsequence('sing', 'sting'); // true
isSubsequence('abc', 'abracadabra'); // true
isSubsequence('abc', 'acb'); // false (order matters)

Your solution MUST have AT LEAST the following complexities:
Time Complexity - O(N + M)
Space Complexity - O(1)
*/

function isSubsequence(inputOne, inputTwo) {
  let i = 0;
  let j = 0;

  while (i < inputOne.length && j < inputTwo.length) {
    if (inputOne[i] === inputTwo[j]) i++;

    j++;
  }

  if (i >= inputOne.length) return true;

  return false;
}

console.log(isSubsequence('hello', 'hello world'));
console.log(isSubsequence('sing', 'sting'));
console.log(isSubsequence('abc', 'abracadabra'));
console.log(isSubsequence('abc', 'acb'));
