// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

// int ReadNumber(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// //true - есть элемент в массиве
// //false - элемент в массиве отсутствует
// bool IsNumberInArray(int[] arr, int findNumber)
// {
//     bool isNumberInArray = false; //
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == findNumber)
//         {
//             isNumberInArray = true;
//         }
//     }
//     return isNumberInArray;
// }