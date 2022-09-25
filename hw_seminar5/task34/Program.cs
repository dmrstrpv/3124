﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int [] array = new int [4];

void FillArray(int [] arr)
{
    for(int i = 0; i < arr.Length; i++) 
    {
        arr[i] = new Random().Next(100, 1000);
    }

}

 int IsEvenCheck(int [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++) 
    {
        
        if(arr[i] % 2 == 0) 
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
IsEvenCheck(array);
Console.WriteLine();
Console.Write($"Количество чётных чисел в массиве {IsEvenCheck(array)}");