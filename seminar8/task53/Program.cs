//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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
            arr[i, j] = randomNum.Next(leftRange, rightRange + 1);
        }

    }

    return arr;

}

void LinesSwap(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
    }

    Console.WriteLine();

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

int lines = ReadNumber("Введите количество строк");
int rows = ReadNumber("Введите количество столбцов");
Console.WriteLine();

int[,] matrix = FillMatrix(lines, rows, 1, 10);
PrintMatrix(matrix);
LinesSwap(matrix);
PrintMatrix(matrix);