Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void TriangleCheck(int sideOne, int sideTwo, int sideThree)
{
    if (sideOne < sideTwo + sideThree && sideTwo < sideOne + sideThree && sideThree < sideOne + sideTwo)
    {
        System.Console.WriteLine("Такой треугольник может существовать");
    }
    else
    {
        System.Console.WriteLine("Такой треугольник НЕ может существовать");
    }
}

int firstSide = DataEntry("Введите первую сторону треугольника: ");
int secondSide = DataEntry("Введите вторую сторону треугольника: ");
int thirdSide = DataEntry("Введите третью сторону треугольника: ");
TriangleCheck(firstSide, secondSide, thirdSide);
