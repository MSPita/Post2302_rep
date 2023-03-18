// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

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

void Position(int[,] arr, int m, int n)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (m > row || n > column)
        Console.WriteLine("Такого элемента в массиве нет.");

    else
        Console.WriteLine($"Элемент в массиве -> {arr[(m - 1), (n - 1)]}");
    
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

Console.Write("Задайте строку искомого элемента -> ");
int m_num = int.Parse(Console.ReadLine()!);
Console.Write("Задайте столбец искомого элемента -> ");
int n_num = int.Parse(Console.ReadLine()!);


Position(mass, m_num, n_num);






