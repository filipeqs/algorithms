/*
Frequency Counter - sameFrequency
Write a function called sameFrequency. Given two positive integers, find out if the two numbers have the same frequency of digits.

Your solution MUST have the following complexities:

Time: O(N)

Sample Input:

sameFrequency(182,281) // true
sameFrequency(34,14) // false
sameFrequency(3589578, 5879385) // true
sameFrequency(22,222) // false
*/

function sameFrequency(numberOne, numberTwo) {
    const numberOneString = numberOne.toString();
    const numberTwoString = numberTwo.toString();
    if (numberOneString.length !== numberTwoString.length) return false;

    let frequency = {};

    for (let i = 0; i < numberOneString.length; i++) {
        if (!frequency[numberOneString[i]]) frequency[numberOneString[i]] = 1;
        else frequency[numberOneString[i]]++;
    }

    for (let i = 0; i < numberTwoString.length; i++) {
        if (frequency[numberTwoString[i]] && frequency[numberTwoString[i]] > 0)
            frequency[numberTwoString[i]]--;
        else return false;
    }

    return true;
}

console.log(sameFrequency(182, 281)); // true
console.log(sameFrequency(34, 14)); // false
console.log(sameFrequency(3589578, 5879385)); // true
console.log(sameFrequency(22, 222)); // false
