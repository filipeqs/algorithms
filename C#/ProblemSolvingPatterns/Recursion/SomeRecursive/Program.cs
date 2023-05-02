/*
Write a recursive function called someRecursive which 
accepts an array and a callback. The function returns 
true if a single value in the array returns true when 
passed to the callback. Otherwise it returns false.

// SAMPLE INPUT / OUTPUT
// const isOdd = val => val % 2 !== 0;

// someRecursive([1,2,3,4], isOdd) // true
// someRecursive([4,6,8,9], isOdd) // true
// someRecursive([4,6,8], isOdd) // false
// someRecursive([4,6,8], val => val > 10); // false
*/

bool SomeRecursive(List<int> arr, Func<int, bool> callBack) {
    if (arr.Count == 0)
        return false;

    var index = arr.Count - 1;
    var current = arr[index];
    arr.RemoveAt(index);

    return isOdd(current) || SomeRecursive(arr, callBack);
}

bool isOdd(int val) => val % 2 != 0;

Console.WriteLine(SomeRecursive(new List<int> { 1, 2, 3, 4 }, (val) => val % 2 != 0));
Console.WriteLine(SomeRecursive(new List<int> { 4, 6, 8, 9 }, isOdd));
Console.WriteLine(SomeRecursive(new List<int> { 4, 6, 8 }, isOdd));
Console.WriteLine(SomeRecursive(new List<int> { 4, 6, 8 }, isOdd));