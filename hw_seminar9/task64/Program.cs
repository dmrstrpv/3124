// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadLine(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteAllNumbers(int n)
{
    if (n <= 0)
    {
        return;
    }
    else
    {
        WriteAllNumbers(n - 1);
        Console.Write(n + " ");
    }
}


int N = ReadLine("Введите число: ");
WriteAllNumbers(N);