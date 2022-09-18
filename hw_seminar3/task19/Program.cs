// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int numberReversed = 0;

while (temp>0) 
{
    int temp1 = temp % 10;
    numberReversed = numberReversed * 10 + temp1;
    temp = temp / 10;   
}

if (numberReversed == num) 
{
    Console.WriteLine($"{numberReversed} -> да");
}
else 
{
    Console.WriteLine($"{numberReversed} -> нет");
}


