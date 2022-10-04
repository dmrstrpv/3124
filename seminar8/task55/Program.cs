//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


void MatrixCopy(int[,] array1, int[,] array2)
{

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                array1[i, k] = array2[k, i];
            }
        }
    }

}



int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] arr = new int[rowsCount, columnsCount];

    Random random = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(leftRange, rightRange);
        }

    }

    return arr;

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


int lines = 4; //ReadNumber("Введите количество строк");
int columns = 4; //ReadNumber("Введите количество столбцов");


int[,] matrix1 = FillMatrix(lines, columns, 1, 10);
int[,] matrix2 = FillMatrix(lines, columns, 1, 10);

MatrixCopy(matrix1, matrix2);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();