// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (5 < num && num < 8)
{
Console.Write(" -> Да");
}

else if (0 < num && num < 6)

{
  Console.Write(" -> Нет");  
}

else if (num < 0 || num > 7)

{
    Console.WriteLine("В неделе 7 дней"); 
}