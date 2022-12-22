const int SIZE = 8;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 100;

int[] array = new int[SIZE];
int[] array2 = new int[SIZE];

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0 ; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] CopyArray(int[] arr)
{
    int[] arr2 = new int[arr.Length];
    for (int i = 0; i < arr2.Length; i++)
    {
        arr2[i] = arr[i];
    }
    return arr2;
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
array2 = CopyArray(array);
Console.WriteLine($"[{string.Join(", ", array2)}]");