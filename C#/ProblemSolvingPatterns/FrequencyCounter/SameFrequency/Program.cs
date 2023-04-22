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

bool SameFrequency(int numOne, int numTwo) {
    var numOneString = numOne.ToString();
    var numTwoString = numTwo.ToString();
    if (numOneString.Length != numTwoString.Length)
        return false;

    var frequency = new Dictionary<char, int>();

    for (int i = 0; i < numOneString.Length; i++)
    {
        if (!frequency.ContainsKey(numOneString[i]))
            frequency.Add(numOneString[i], 1);
        else
            frequency[numOneString[i]]++;
    }

    for (int i = 0; i < numTwoString.Length; i++) 
    {
        if (frequency.ContainsKey(numTwoString[i]) && frequency[numTwoString[i]] > 0)
            frequency[numTwoString[i]]--;
        else
            return false;  
    }

    return true;
}

Console.WriteLine(SameFrequency(182, 281));
Console.WriteLine(SameFrequency(34, 14));
Console.WriteLine(SameFrequency(3589578, 5879385));
Console.WriteLine(SameFrequency(22, 222));