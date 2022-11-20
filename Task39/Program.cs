// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


Console.Clear();
Console.WriteLine("Type the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the maximum element: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the minimum element: ");
int min = Convert.ToInt32(Console.ReadLine());

int [] array = GetArray(size, max, min);

Console.WriteLine(String.Join(",", array));

ChangeArray(array);
Console.WriteLine(String.Join(",", array));



int[] GetArray(int size, int max, int min)
{
    int [] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max+1);
    }
    return res;
}


void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = k;
    }
}