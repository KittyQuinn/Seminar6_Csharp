// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

Console.WriteLine("Type the count of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());

int num1 = 0;
int num2 = 1;
Console.WriteLine(1+"|"+num1);
Console.WriteLine(2+"|"+num2);

for (int i = 3; i < size; i++)
{
    int next_num = num1+num2;
    Console.WriteLine(i+"|"+next_num);
    num1 = num2;
    num2 = next_num;
}