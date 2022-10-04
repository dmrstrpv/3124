// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9


// void FrequencyDict(int[,] array1)
// {

//     for (int i = 0; i < array2.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int k = 0; k < array2.GetLength(1); k++)
//             {
//                 array1[i, k] = array2[k, i];

//                 Console.WriteLine($"");
//             }
//         }
//     }

// }



// int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
// {
//     int[,] arr = new int[rowsCount, columnsCount];

//     Random random = new Random();

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(leftRange, rightRange);
//         }

//     }

//     return arr;

// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int lines = 4; //ReadNumber("Введите количество строк");
// int columns = 4; //ReadNumber("Введите количество столбцов");


// int[,] matrix1 = FillMatrix(lines, columns, 1, 10);
// int[,] matrix2 = FillMatrix(lines, columns, 1, 10);

// MatrixCopy(matrix1, matrix2);

// PrintMatrix(matrix1);
// Console.WriteLine();
// PrintMatrix(matrix2);
// Console.WriteLine();


const int ROWS = 3; //число строк
const int COLUMNS = 4; //число столбцов

int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] sourceMatrix = FillMatrixRandomNumbers(ROWS, COLUMNS);
PrintMatrix(sourceMatrix);

int[] countingArray = new int[10]; //массив для записи повторений каждого элемента от 0 до 9 
//см. как работает "сортировка подсчетом"


for (int i = 0; i < sourceMatrix.GetLength(0); i++)
{
    for (int j = 0; j < sourceMatrix.GetLength(1); j++)
    {
        countingArray[sourceMatrix[i, j]]++;
    }
}

for(int i = 0; i < countingArray.Length; i++)
{
    if (countingArray[i] != 0) Console.WriteLine($"Количество повторений для {i} = {countingArray[i]}");
}