// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadNumber("Введите число 1");
int b = ReadNumber("Введите число 2");
int c = ReadNumber("Введите число 3");

void TriangleCheck (int a, int b, int c) 
{
    if (a < b + c & b < a + c & c < a + b)
    {
        Console.Write("Cуществовать треугольник со сторонами такой длины может.");
    }
    else Console.Write("Треугольник с сторонами такой длины не может существовать.");

}

TriangleCheck(a, b, c);