// // 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

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


string RowToColumn(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("невозможно");
        return "";

    }
    else
    {

        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
            }
        }
        Print(array);
        return "BOT!";
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

string result = RowToColumn(mass);
Console.WriteLine(result);
//Print(mass);

