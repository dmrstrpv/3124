// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int [] array = new int [123];

void FillArray(int [] arr)
{
    for(int i = 0; i < arr.Length; i++) 
    {
        arr[i] = new Random().Next(0, 150);
    }

}

 int IsDoubleCheck(int [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++) 
    {
        
        if(arr[i] < 100 & arr[i] > 10) 
        {
            count++;
            count = count++;
        }
    }
    return count;

}

void PrintArray(int [] arr)
{
    for(int i = 0; i < arr.Length; i++) 
    {
        Console.Write($"{arr[i]} ");
    }

}

FillArray(array);
PrintArray(array);
IsDoubleCheck(array);
Console.WriteLine();
Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99] {IsDoubleCheck(array)}");
