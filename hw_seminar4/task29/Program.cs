// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [] numbers = new int [8];

void ReadArr(int[] numbers)
{
    int index = 0;
    int length = numbers.Length;
    while (index < length) 
    {
        numbers[index] = ReadNumber("Введите число: ");
        index++;
    }
}

void PrintArr (int [] col) 
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(col[pos] + " ");
        pos++;
    }
}

ReadArr(numbers);
PrintArr(numbers);


