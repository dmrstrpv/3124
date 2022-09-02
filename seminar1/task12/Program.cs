// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Random random_num = new Random();
// int num = random_num.Next(10, 100);
// Random random_num1 = new Random();
// int num1 = random_num1.Next(10, 100);

Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int x = 0;

// Console.WriteLine ($"Сгенерированно случайное число {num}");
// Console.WriteLine ($"Сгенерированно случайное число {num1}");


if (num % num1 == 0)
{
    Console.WriteLine ($"Второе число {num1} является кратным первому {num}");
}

else if (num % num1 != 0)

{
    x = num % num1;
    Console.WriteLine ($"Второе число {num1} не является кратным первому {num} остаток {x}");
}
