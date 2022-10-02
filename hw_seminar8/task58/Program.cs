// /Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void MatrixMultiplication(int[,] array1, int[,] array2, int[,] array3)
{

    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            for (int k = 0; k < array3.GetLength(1); k++)
            {
                int temp = array1[i, k] * array2[i, k];
                array3[i, k] = temp;

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
int[,] matrixResult = FillMatrix(lines, columns, 1, 10);

MatrixMultiplication(matrix1, matrix2, matrixResult);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(matrixResult);