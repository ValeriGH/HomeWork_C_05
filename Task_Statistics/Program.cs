void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

int OddDays(int[] array)
{
    int sumOddNum = 0; //sumEvenNum = 0;
    Console.Write("Нечетные числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            sumOddNum++;
            Console.Write($"{array[i]} ");
        }
    }
    return sumOddNum;
}

int EvenDays(int[] array)
{
    int sumEvenNum = 0;
    Console.Write("\nЧетные числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sumEvenNum++;
            Console.Write($"{array[i]} ");
        }
    }
    return sumEvenNum;
}
string Desition(int oddDays, int evenDays)
{
    if (evenDays >= oddDays)
        return "\nYes";
    else
        return "\nNo";
}


Console.Clear();
Console.Write("Введи количество оценок: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
CreateArray(array);
Console.WriteLine($"[{string.Join(" ", array)}]");
int countOddDays = OddDays(array);
//Console.WriteLine(countOddDays);
int countEvenDays = EvenDays(array);
Console.WriteLine(Desition(countOddDays, countEvenDays));