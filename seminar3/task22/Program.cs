// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine ("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    for (int count = 1; count <= num; count++)
    {
        Console.Write (count*count + " ");
    }
}
else 
{
    Console.Write ("Введите положительное число");
}