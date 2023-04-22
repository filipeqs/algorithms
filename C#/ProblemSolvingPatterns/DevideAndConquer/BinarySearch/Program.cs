/*
Given a sorted array of integers, write a function called search, 
that accepts a value and returns the index where the value passed 
to the function is located. If the value is not found, return -1

search([1,2,3,4,5,6],4) // 3
search([1,2,3,4,5,6],6) // 5
search([1,2,3,4,5,6],11) // -1
*/

int Search(int[] arr, int n) 
{
    if (arr.Length == 0)
        return -1;

    decimal left = 0;
    decimal right = arr.Length - 1;

    while(left <= right) {
        var middle = (int)Math.Floor((left + right) / 2);
        if (arr[middle] == n)
            return middle;
        
        if (arr[middle] < n) 
            left = middle + 1;
        else
            right = middle - 1;
    }

    return -1;
}

Console.WriteLine(Search(new int[] {1,2,3,4,5,6}, 4));
Console.WriteLine(Search(new int[] {1,2,3,4,5,6}, 6));
Console.WriteLine(Search(new int[] {1,2,3,4,5,6}, 11));
