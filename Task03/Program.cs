Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void ToBinary(int num)
{
    if(num <= 0)
    {
        return;
    }
    ToBinary(num / 2);
    System.Console.Write(num % 2);
}

int number = DataEntry("введите десятичное число: ");
ToBinary(number);