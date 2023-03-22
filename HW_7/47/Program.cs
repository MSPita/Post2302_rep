// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
}

double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(new Random().NextDouble() * (from - to) + to , 2);
    return arr;
}
Console.Write("Количество строк -> ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов -> ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапазона -> ");
double start = double.Parse(Console.ReadLine()!);
Console.Write("Конец диапазона -> ");
double stop = double.Parse(Console.ReadLine()!);
Console.WriteLine();
double[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);