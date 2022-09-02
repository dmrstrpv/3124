// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


Random random_num = new Random();
int num = random_num.Next(10, 100);

int num2 = num % 10;
int num1 = num / 10;

Console.WriteLine ($"Сгенерированно случайное число {num}");
Console.WriteLine(num1);
Console.WriteLine(num2);

if (num1 > num2)
{
    Console.WriteLine ("Наибольшая цифра числа " + num + " -> "+ num1);
}
else if (num1 < num2)
{
    Console.WriteLine ("Наибольшая цифра числа " + num + " -> " + num2);
}
else
{
    Console.WriteLine ("Цифры равны");
}