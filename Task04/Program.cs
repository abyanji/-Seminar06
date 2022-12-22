Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Fibonachi(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    int i;
    for(i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}

int number = DataEntry("введите число: ");
Fibonachi(number);
