/*
Frequency Counter - validAnagram
Given two strings, write a function to determine 
if the second string is an anagram of the first. 
An anagram is a word, phrase, or name formed by 
rearranging the letters of another, such as cinema, 
formed from iceman.

Examples:

validAnagram('', '') // true
validAnagram('aaz', 'zza') // false
validAnagram('anagram', 'nagaram') // true
validAnagram("rat","car") // false)
validAnagram('awesome', 'awesom') // false
validAnagram('amanaplanacanalpanama', 'acanalmanplanpamana') // false
validAnagram('qwerty', 'qeywrt') // true
validAnagram('texttwisttime', 'timetwisttext') // true
Note: You may assume the string contains only lowercase alphabets.

Time Complexity - O(n)
*/

function validAnagram(first, second) {
    if (first.length != second.length) return false;

    const frequency = {};

    for (let i = 0; i < first.length; i++) {
        const value = first[i];
        if (frequency[value]) frequency[value]++;
        else frequency[value] = 1;
    }

    for (let i = 0; i < second.length; i++) {
        const value = second[i];
        if (frequency[value] && frequency[value] > 0) frequency[value]--;
        else return false;
    }

    return true;
}

console.log(validAnagram('', ''));
console.log(validAnagram('aaz', 'zza'));
console.log(validAnagram('anagram', 'nagaram'));
console.log(validAnagram('rat', 'car'));
console.log(validAnagram('awesome', 'awesom'));
console.log(validAnagram('amanaplanacanalpanama', 'acanalmanplanpamana'));
console.log(validAnagram('qwerty', 'qeywrt'));
console.log(validAnagram('texttwisttime', 'timetwisttext'));
