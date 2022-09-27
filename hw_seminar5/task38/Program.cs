// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int [] array = new int [5];

void FillArray(int [] arr)
{
    for(int i = 0; i < arr.Length; i++) 
    {
        arr[i] = new Random().Next(1, 100);
    }

}

int MaxMinArrayElementDiff(int [] arr)
{
    int diff = 0;
    int max = 0;
    int min = 10;
    for(int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
        
        diff = max - min;
    }
    return diff;

}


void PrintArray(int [] arr)
{
    for(int i = 0; i < arr.Length; i++) 
    {
        Console.Write($"{arr[i]} ");
    }

}

FillArray(array);
Console.WriteLine("Задан одномерный массив натуральных чисел.");
PrintArray(array);
MaxMinArrayElementDiff(array);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементами массива {MaxMinArrayElementDiff(array)}");