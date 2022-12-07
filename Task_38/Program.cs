// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"Введите {i + 1} элемент: ");
        array[i] = double.Parse(Console.ReadLine());       
    }
}

double MinNum(double[] array)
{
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNumber)
            minNumber = array[i];
    }
    return minNumber;
}

double MaxNum(double[] array)
{
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
            maxNumber = array[i];
    }
    return maxNumber;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(" ", array)}]");
Console.WriteLine($"Разница между max и min числами: {MaxNum(array) - MinNum(array)}");
