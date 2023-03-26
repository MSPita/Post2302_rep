//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j],3}");
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


int[] SumRows(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] sum = new int[row];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            sum[i] += arr[i, j];
    return sum;
}

int Min(int[] arr)
{
    int minindex = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] < arr[minindex]) minindex = i;
    return minindex;
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

int[] sums = SumRows(mass);
int numRow = Min(sums);
Console.WriteLine($"номер строки с наименьшей суммой {numRow+1}");



