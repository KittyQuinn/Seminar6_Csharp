// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Каждая сторона треугольника меньше суммы двух других

Console.Clear();

Console.WriteLine("Type the first side of triangle ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the second side of triangle ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the trird side of triangle ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b+c & b < a+c & c < a+b) Console.WriteLine("Yes");

else Console.WriteLine("No");
