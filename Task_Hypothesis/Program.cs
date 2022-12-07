// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, причём таких разложений может быть несколько.
// Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.

// Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа. Из всех пар простых чисел, 
// сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.
// Входной файл INPUT.TXT содержит чётное число N (4 ≤ N ≤ 998).
// В выходной файл OUTPUT.TXT необходимо вывести два простых числа,сумма которых равна числу N. Первым выводится наименьшее число.

void InputArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
        array[i] = array[i - 1] + 1;
}

void Sieve(int[] array) // Решето Эратосфена
{
    // 0 - непростое число
    array[1] = 0;
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            for (int j = i * 2; j < array.Length; j += i)
            {
                array[j] = 0;
            }
        }
    }
}

void Solution(int[] array)
{
    for (int i = 2; i <= (array.Length / 2); i++)
    {
        if (array[i] != 0)
        {
            for (int j = array.Length / 2; j < array.Length; j++)
            {
                if (array[j] != 0)
                {
                    if (i + j == array.Length)
                    {
                        Console.WriteLine($"{i} {j}");
                        i = array.Length; // выход из циклов
                    }
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Введите четное число от 4 до 998: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 4 || n > 998 || n % 2 == 1)
{
    Console.Write("Ошибка!\nВведите четное число от 4 до 998: ");
    n = Convert.ToInt32(Console.ReadLine());
}

// нахождение простых чисел из диапазона [0, n]
int[] simpleNum = new int[n];
InputArray(simpleNum);
//Console.WriteLine($"[{string.Join(", ", simpleNum)}]");
Sieve(simpleNum);
//Console.WriteLine($"[{string.Join(", ", simpleNum)}]");
Solution(simpleNum);