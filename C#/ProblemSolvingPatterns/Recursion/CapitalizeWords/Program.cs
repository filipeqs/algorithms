/*
Write a recursive function called capitalizeWords. 
Given an array of words, return a new array containing 
each word capitalized.

let words = ['i', 'am', 'learning', 'recursion'];
*/

List<string> CapitalizeWords(List<string> words) {
    if (words.Count == 1)
        return new List<string>{ words[0].ToUpper() }; 

    var current = words[0];
    words.RemoveAt(0);

    var newWords = new List<string> { current.ToUpper() };
    newWords.AddRange(CapitalizeWords(words));
    return newWords;
}

var words = new List<string>{ "i", "am", "learning", "recursion" };
var result = CapitalizeWords(words);
foreach (var word in result)
    Console.WriteLine(word);

