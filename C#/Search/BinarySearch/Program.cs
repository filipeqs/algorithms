int Search(List<int> list, int number) 
{
    // Create two pointers
    decimal left = 0;
    decimal right = list.Count;

    // Loop through list while left is less than right;
    while(left <= right) {
        // Find the middle point
        var middle = (int)Math.Floor((left + right) / 2);

        // Check if found
        if (list[middle] == number) 
            return middle;

        // If middle is less than number, 
        // it means its on the right side of the array
        // else its on the left side
        if (list[middle] <= number) 
            left = middle + 1;
        else
            right = middle - 1;
    }

    return -1;
}

var list = new List<int> { 1, 2, 5, 6, 7, 9 };
var result = Search(list, 2);
Console.WriteLine(result);