List<int> Merge(List<int> arrOne, List<int> arrTwo) {
    var newArr = new List<int>();
    var i = 0;
    var j = 0;

    while (i < arrOne.Count && j < arrTwo.Count) 
    {
        if (arrOne[i] < arrTwo[j])
        {
            newArr.Add(arrOne[i]);
            i++;
        }
        else
        {
            newArr.Add(arrTwo[j]);
            j++;
        }
    }

    while (i < arrOne.Count)
    {
        newArr.Add(arrOne[i]);
        i++;
    }

    while (j < arrTwo.Count)
    {
        newArr.Add(arrTwo[j]);
        j++;
    }

    return newArr;
}

List<int> MergeSort(List<int> arr) {
    if (arr.Count == 1) return arr;

    var middle = (int)Math.Floor((decimal)arr.Count / 2);
    var left = MergeSort(arr.Take(middle).ToList());
    var right = MergeSort(arr.Skip(middle).ToList());

    var result = Merge(left, right);

    return result;
}

var input = new List<int> {1, 4, 7, 3, 2};
var result = MergeSort(input);
foreach(var item in result)
    System.Console.WriteLine(item);