int[] SelectionSort(int[] arr) 
{
    for(var i = 1; i < arr.Length; i++) {
        for(var j = i; j > 0; j--) {
            if (arr[j] < arr[j - 1])
                Swap(arr, j, j - 1);
        }
    }

    return arr;
}

void Swap(int[] arr, int i, int j) 
{
    var temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

var arr = new int[] { 5, 3, 4, 1, 2 };
var result = SelectionSort(arr);

foreach (var item in result) {
    System.Console.WriteLine(item);
}

// [5, 3, 4, 1, 2]
// [3, 5, 4, 1, 2]
// [3, 4, 5, 1, 2]
// [1, 3, 4, 5, 2]
// [1, 2, 3, 4, 5]