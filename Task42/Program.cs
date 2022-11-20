// Задача 42: Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

Console.WriteLine("Type a number ");
int num = Convert.ToInt32(Console.ReadLine());

string bin = "";

while (num>0)
{
    bin = num%2+bin;
    num /= 2;
}

Console.WriteLine(bin);