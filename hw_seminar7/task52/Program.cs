// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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


void GetAverage(int[,] arr, int rowNum, int columnNum)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double avgColumnNum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            avgColumnNum = avgColumnNum + arr[i, j];
        }

        avgColumnNum = avgColumnNum / rowNum;
        Console.Write($"{avgColumnNum}; ");
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


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");

int[,] matrix = FillMatrix(m, n, 1, 10);
PrintMatrix(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
GetAverage(matrix, m, n);