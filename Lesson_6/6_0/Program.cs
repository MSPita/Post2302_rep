﻿//напишите программу, которая 
//перевернет одномерный массив.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Nums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);

    return arr;
}

void RevMas(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size / 2; i++)
    {
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
    }
    

}

Console.WriteLine("Задайте размер массива ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте начало массива ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте конец массива ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = Nums(num, start, stop);
Print(mass);
RevMas(mass);
Print(mass);
