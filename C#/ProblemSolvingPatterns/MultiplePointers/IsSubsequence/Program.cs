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

bool IsSubsequence(string inputOne, string inputTwo) {
    var i = 0;
    var j = 0;

    while(i < inputOne.Length && j < inputTwo.Length) {
        if (inputOne[i] == inputTwo[j])
            i++;

        j++;
    }

    if (i >= inputOne.Length)
        return true;

    return false;
}

Console.WriteLine(IsSubsequence("hello", "hello world"));
Console.WriteLine(IsSubsequence("sing", "sting"));
Console.WriteLine(IsSubsequence("abc", "abracadabra"));
Console.WriteLine(IsSubsequence("abc", "acb"));