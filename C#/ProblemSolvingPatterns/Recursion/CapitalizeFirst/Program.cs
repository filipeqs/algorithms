/*
Write a recursive function called capitalizeFirst. 
Given an array of strings, capitalize the first 
letter of each string in the array.

capitalizeFirst(['car','taco','banana']); // ['Car','Taco','Banana']
*/

using CapitalizeFirst;

List<string> CapitalizeFirst(List<string> input) 
{
    if (input.Count == 1)
    {
        input[0] = input[0].FirstCharToUpper();
        return input;
    }

    var newList = new List<string> { input[0].FirstCharToUpper() };
    input.RemoveAt(0);
    newList.AddRange(CapitalizeFirst(input));

    return newList;
}

var input = CapitalizeFirst(new List<string> { "car", "taco", "banana" });
var result = CapitalizeFirst(new List<string> { "car", "taco", "banana" });
result.ForEach(value => Console.WriteLine(value));
