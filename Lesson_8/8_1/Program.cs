//1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.
//
//
void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Massiv(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void ReplaceIndex(int[,] array)
{
    int Row = array.GetLength(0);
    int Column = array.GetLength(1);
    
    for (int j = 0; j < Column; j++)
    {
        (array[0,j] , array[Row - 1 ,j]) = (array[Row - 1, j], array[0,j]);
    }
}


Console.Write("Количество строк -> ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов -> ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапазона -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапазона -> ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] mass = Massiv(row_num, column_num, start, stop);
Print(mass);

ReplaceIndex (mass);
Print(mass);

