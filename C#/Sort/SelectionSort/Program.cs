int[] SelectionSort(int[] arr) {
    for (var i = 0; i < arr.Length; i++) 
    {
        var lowerIndex = i;
        for (var j = i; j < arr.Length; j++) 
        {
            if (arr[j] < arr[lowerIndex]) 
                lowerIndex = j;
        }
        Swap(arr, i, lowerIndex);
    }

    return arr;
}

void Swap(int[] arr, int i, int j) 
{
    var temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

var arr = new int[] {5, 3, 4, 1, 2};
var result = SelectionSort(arr);
foreach (var item in result) {
    System.Console.WriteLine(item);
}

// [5, 3, 4, 1, 2]
// [1, 3, 4, 5, 2]
// [1, 2, 4, 5, 3]
// [1, 2, 3, 5, 4]
// [1, 2, 3, 4, 5]