// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Random random_num = new Random();
int num = random_num.Next(1, 10000000);
Console.WriteLine ($"Сгенерированно случайное число {num}");

string num_text = Convert.ToString(num);

if (num_text.Length > 2)
{
    Console.WriteLine ($"{num} -> {num_text[2]}");
}
else 
{
    Console.WriteLine ($" {num} -> третьей цифры нет");
}
