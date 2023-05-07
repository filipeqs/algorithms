int Pivot(int[] arr, int start = 0, int? end = null) 
{
    end = end ?? arr.Length;

    var pivot = arr[start];
    var pivotIndex = start;

    for (int i = start; i < end; i++)
    {
        if (pivot > arr[i]) 
        {
            pivotIndex++;
            Swap(arr, i, pivotIndex);
        }
    }

    Swap(arr, start, pivotIndex);

    return pivotIndex;
}

void Swap(int[] arr, int i, int j) 
{
    var temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

int[] MergeSort(int[] arr, int start = 0, int? end = null) 
{
    end = end ?? arr.Length;
    if (end - start < 2) return arr;

    var pivot = Pivot(arr, start, end);
    MergeSort(arr, start, pivot - 1);
    MergeSort(arr, pivot + 1, end);

    return arr;
}

var input = new int[] { 5, 2, 1, 8, 4, 7, 6, 3 };
var result = MergeSort(input);
foreach (var item in input)
    System.Console.WriteLine(item);