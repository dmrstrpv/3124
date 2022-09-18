// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNum(int number) 
{
    int temp = 1;
    int result = 0;

    while (number > 0)
    {
        temp = number % 10;
        number = number / 10;
        result = temp + result;
    }
    return result; 
}

int number = ReadNumber("Введите число: ");
int sum = SumNum(number);
Console.WriteLine("Сумма цифр в числе: " + sum);