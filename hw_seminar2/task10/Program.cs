// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random random_num = new Random();
int num = random_num.Next(99, 1000);

int num2 = num % 100/10;

Console.WriteLine (num + " -> " + num2);
