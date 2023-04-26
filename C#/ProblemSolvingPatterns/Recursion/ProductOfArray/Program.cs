/*
Write a function called productOfArray which takes in an 
array of numbers and returns the product of them all.
*/

int ProductOfArray(int[] input) 
{
    if (input.Length == 0)
        return 1;

    var lastValue = input[input.Length - 1];
    var newArray = input.SkipLast(1).ToArray();

    return lastValue * ProductOfArray(newArray);
}

Console.WriteLine(ProductOfArray(new int[] {1, 3, 5}));