// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numA = ReadNumber("Введите первое число ");
int numB = ReadNumber("Введите второе число ");

int NumberAtoBPower(int numberA, int numberB) 
{
    int count = 0;
    int temp = 1;
    while (count < numberB)
    {
        temp = temp * numberA;
        count++;
    }
    return temp; 
}

int numPow = NumberAtoBPower(numA, numB);

Console.WriteLine(numPow);

//Console.WriteLine (numA);