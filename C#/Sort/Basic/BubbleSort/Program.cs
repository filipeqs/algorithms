int[] BubbleSort(int[] input) {
    for (int i = input.Length; i > 0; i--)
    {
        for (int j = 0; j < i - 1; j++)
        {
            if (input[j] > input[j + 1]) 
            {
                var temp = input[j];
                input[j] = input[j + 1];
                input[j + 1] = temp;
            }
        }
    }

    return input;
}

var arr = new int[] { 5, 3, 4, 1, 2 };

var result = BubbleSort(arr);

foreach (var item in result) 
    Console.WriteLine(item);