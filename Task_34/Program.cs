// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
void PositiveNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
CreateArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
PositiveNumber(array);