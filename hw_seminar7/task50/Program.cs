// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] arr = new int[rowsCount, columnsCount];

    Random randomNum = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNum.Next(leftRange, rightRange);
        }

    }

    return arr;

}


void GetValue(int[,] arr, int rowNum, int columnNum)
{
    if (rowNum > arr.GetLength(0) || columnNum > arr.GetLength(1))
    {
        Console.WriteLine($"{rowNum} {columnNum} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента {arr[rowNum - 1, columnNum - 1]}");
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


int m = ReadNumber("Введите номер строки");
int n = ReadNumber("Введите номер столбца");
int[,] arr = FillMatrix(3, 4, 1, 10);
PrintMatrix(arr);
GetValue(arr, m, n);