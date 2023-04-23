/*
Implement a function called, areThereDuplicates which 
accepts a variable number of arguments, and checks 
whether there are any duplicates among the arguments 
passed in.  You can solve this using the frequency 
counter pattern OR the multiple pointers pattern.

Examples:

areThereDuplicates(1, 2, 3) // false
areThereDuplicates(1, 2, 2) // true 
areThereDuplicates('a', 'b', 'c', 'a') // true 
Restrictions:

Time - O(n)

Space - O(n)

Bonus:

Time - O(n log n)

Space - O(1)
*/

function areThereDuplicates(input) {
  const frequency = {};

  for (let i = 0; i < input.length; i++) {
    const value = input[i];
    if (frequency[value]) return true;

    frequency[value] = 1;
  }

  return false;
}
