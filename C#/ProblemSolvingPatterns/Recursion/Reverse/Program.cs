/*
Write a recursive function called reverse which 
accepts a string and returns a new string in reverse.
*/

string Reverse(string word) {
    if (word.Length == 0)
        return "";
    
    var index = word.Length - 1;
    var character = word[index].ToString();
    var newWord = word.Remove(index, 1);

    return character + Reverse(newWord);
}

Console.WriteLine(Reverse("test"));