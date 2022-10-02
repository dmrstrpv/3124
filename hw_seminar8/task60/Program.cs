// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)


int[,,] FillMatrix(int rowsCount, int columnsCount, int depthCount, int leftRange, int rightRange)
{
    int[,,] arr = new int[2, 2, 2];

    Random randomNum = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                arr[i, j, k] = randomNum.Next(leftRange, rightRange);
            }

        }

    }

    return arr;

}




void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[i, j, k]} {(i, j, k)} ");
            }
            Console.WriteLine();

        }

    }
}


int m = 2;
int n = 2; 
int o = 2; 

int[,,] matrix = FillMatrix(m, n, o, 10, 100);
PrintMatrix(matrix);