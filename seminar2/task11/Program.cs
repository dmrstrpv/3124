// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



Random random_num = new Random();
int num = random_num.Next(99, 1000);

int num3 = num % 1000/100;
int num2 = num % 100/10;
int num1 = num % 10;

Console.WriteLine ($"Сгенерированно случайное трёхзначное число {num}");
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);

Console.WriteLine (num3 + "" + num1);
Console.WriteLine (num3 * 10 + num1);


// if (num1 > num2)
// {
//     Console.WriteLine ("Наибольшая цифра числа " + num + " -> "+ num1);
// }
// else if (num1 < num2)
// {
//     Console.WriteLine ("Наибольшая цифра числа " + num + " -> " + num2);
// }
// else
// {
//     Console.WriteLine ("Цифры равны");
// }