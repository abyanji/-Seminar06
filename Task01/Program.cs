Console.Clear();
const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;
int[] array = new int[SIZE];

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

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReverseArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");