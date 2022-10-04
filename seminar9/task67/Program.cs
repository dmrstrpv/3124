// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumSum(int n)
{
    if (n == 0) { return n; }
    else { return NumSum(n / 10) + n % 10; }
}

int n = ReadNumber("Введите число:");
Console.WriteLine(NumSum(n));