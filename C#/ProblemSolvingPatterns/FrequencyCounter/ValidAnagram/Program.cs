/*
Frequency Counter - validAnagram
Given two strings, write a function to determine if 
the second string is an anagram of the first. 
An anagram is a word, phrase, or name formed by rearranging 
the letters of another, such as cinema, formed from iceman.

Examples:

validAnagram('', '') // true
validAnagram('aaz', 'zza') // false
validAnagram('anagram', 'nagaram') // true
validAnagram("rat","car") // false) // false
validAnagram('awesome', 'awesom') // false
validAnagram('amanaplanacanalpanama', 'acanalmanplanpamana') // false
validAnagram('qwerty', 'qeywrt') // true
validAnagram('texttwisttime', 'timetwisttext') // true
Note: You may assume the string contains only lowercase alphabets.

Time Complexity - O(n)
*/

bool ValidAnagram(string first, string second) 
{
    if (first.Length != second.Length)
        return false;

    var frequency = new Dictionary<char, int>();

    for (int i = 0; i < first.Length; i++)
    {
        var value = first[i];
        if (frequency.ContainsKey(value))
            frequency[value]++;
        else
            frequency.Add(value, 1);
    }

    for (int i = 0; i < second.Length; i++)
    {
        var value = second[i];
        if (frequency.ContainsKey(value) && frequency[value] > 0)
            frequency[value]--;
        else
            return false;
    }

    return true;
}

Console.WriteLine(ValidAnagram("", ""));
Console.WriteLine(ValidAnagram("awesome", "awesom"));
Console.WriteLine(ValidAnagram("anagram", "nagaram"));
Console.WriteLine(ValidAnagram("rat","car"));
Console.WriteLine(ValidAnagram("awesome", "awesom"));
Console.WriteLine(ValidAnagram("amanaplanacanalpanama", "acanalmanplanpamana"));
Console.WriteLine(ValidAnagram("qwerty", "qeywrt"));
Console.WriteLine(ValidAnagram("texttwisttime", "timetwisttext"));