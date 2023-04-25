/*
Write a function called findLongestSubstring, 
which accepts a string and returns the length 
of the longest substring with all distinct characters.

findLongestSubstring('') // 0
findLongestSubstring('rithmschool') // 7
findLongestSubstring('thisisawesome') // 6
findLongestSubstring('thecatinthehat') // 7
findLongestSubstring('bbbbbb') // 1
findLongestSubstring('longestsubstring') // 8
findLongestSubstring('thisishowwedoit') // 6

Time Complexity - O(n)
*/

function findLongestSubstring(input) {
  if (input.length === 0) return 0;

  let i = 0;
  let j = 0;
  let frequency = {};
  let longest = Number.MIN_VALUE;

  while (j < input.length) {
    const value = input[j];

    if (frequency[value] && frequency[value] > i) {
      i = frequency[value];
    }

    const length = j - i + 1;
    if (length > longest) longest = length;

    j++;
    frequency[value] = j;
  }

  return longest;
}

console.log(findLongestSubstring(''));
console.log(findLongestSubstring('rithmschool'));
console.log(findLongestSubstring('thisisawesome'));
console.log(findLongestSubstring('thecatinthehat'));
console.log(findLongestSubstring('bbbbbb'));
console.log(findLongestSubstring('longestsubstring'));
console.log(findLongestSubstring('thisishowwedoit'));
