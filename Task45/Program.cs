// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования

Console.Clear();

Console.WriteLine("Type the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());


int [] array = new int[size];


for (int i = 0; i < size; i++)
{
    array [i] = new Random().Next(0,21);
    Console.Write(array[i] + " ");
}

int [] array2 = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    array2[i] = array[i];
    
   Console.Write(array2[i] + " ");
}