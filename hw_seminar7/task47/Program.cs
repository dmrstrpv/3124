// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


double [,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    double[,] arr = new double[rowsCount, columnsCount];

    Random randomNum = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(randomNum.Next(leftRange, rightRange + 1));
        }

    }
    return arr;


}

void PrintMatrix(double[,] matrix)
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
double[,] matrix = FillMatrix(m, n, -100, 100);
PrintMatrix(matrix);