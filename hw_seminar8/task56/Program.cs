// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int ReadNumber(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] arr = new int[rowsCount, columnsCount];

    Random random = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(leftRange, rightRange + 1);
        }

    }

    return arr;

}

void MinSumLine(int[,] array)
{
    int minSum = 1000;
    int minSumLineNum = 0;
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = LineSum(array, i);

        if (sum < minSum)
        {
            minSum = sum;
            minSumLineNum = i;
        }
    }
    Console.WriteLine($"\n{minSumLineNum + 1} - строкa с наименьшей суммой ({minSum}) элементов ");
}


int LineSum(int[,] array, int i)
{
    int sum = array[i, 0];

    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }

    return sum;
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


int lines = 4;//ReadNumber("Введите количество строк");
int columns = 3;//ReadNumber("Введите количество столбцов");

Console.WriteLine();
int[,] matrix = FillMatrix(lines, columns, 1, 9);
PrintMatrix(matrix);
MinSumLine(matrix);
Console.WriteLine();
PrintMatrix(matrix);