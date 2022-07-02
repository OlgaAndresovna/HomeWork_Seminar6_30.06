// ДОП задание (если не сделаете, за домашнее задание балл не снизится :) )
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void PrintArr(int[] array)
{
    Console.Write(" ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(array[array.Length - 1] );
    Console.WriteLine();
}

int[] SetArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 50);
    }
    return result;
}

int[] CopyArray(int[] originArray)
{
    Console.Write(" ");
    int[] copy = new int[originArray.Length];
    for (int i = 0; i < originArray.Length; i++)
    {
        copy[i] = originArray[i];
    }
    return copy;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] arr = SetArray(6);
Console.WriteLine("Исходный массив А:");
PrintArr(arr);
Console.WriteLine();
Console.WriteLine("Копия массива A:");
int[] copy = CopyArray(arr);
PrintArray(copy);