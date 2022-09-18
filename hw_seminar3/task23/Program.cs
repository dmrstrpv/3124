// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 1;
int tempCube = 1;
int count = 0;

while (count < num) 
{
    tempCube = temp*temp*temp;
    count++;
    Console.Write(tempCube + " ");
    temp = temp + 1;
}
