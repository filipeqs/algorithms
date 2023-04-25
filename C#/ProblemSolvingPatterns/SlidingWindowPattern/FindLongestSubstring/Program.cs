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

int FindLongestSubstring(string input)
{
    if (input.Length == 0)
        return 0;

    var i = 0;
    var j = 0;
    var frequency = new Dictionary<char, int>();
    var longest = int.MinValue;

    while(j < input.Length) 
    {
        var value = input[j];
        if (frequency.ContainsKey(value) && frequency[value] > i)
            i = frequency[value];
        
        if (!frequency.ContainsKey(value))
            frequency.Add(value, j + 1);
        else 
            frequency[value] = j + 1;

        var tempSize = j - i + 1;
        if (tempSize > longest)
            longest = tempSize;

        j++;
    }

    return longest;
}

Console.WriteLine(FindLongestSubstring(""));
Console.WriteLine(FindLongestSubstring("rithmschool"));
Console.WriteLine(FindLongestSubstring("thisisawesome"));
Console.WriteLine(FindLongestSubstring("thecatinthehat"));
Console.WriteLine(FindLongestSubstring("bbbbbb"));
Console.WriteLine(FindLongestSubstring("longestsubstring"));
Console.WriteLine(FindLongestSubstring("thisishowwedoit"));