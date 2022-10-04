// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadLine(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumSum(int m, int n)
{
    if (n == m)
    {
        return n;
    }

    else if (n > m)
    {
        return n + NumSum(m, n - 1);
    }
    
    else
        return n + NumSum(m, n + 1);

}


int m = ReadLine("Введите первое число:");
int n = ReadLine("Введите второе число:");
Console.WriteLine($"Сумма натуральных элементов -> {NumSum(m, n)}.");