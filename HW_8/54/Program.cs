// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

void Sorting(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    //int[,] sort = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int k = 0; k < column - 1; k++)
            for (int j = 0; j < column - 1; j++)

            {
                if (arr[i, j] <= arr[i, j + 1])
                    (arr[i, j], arr[i, j + 1]) = (arr[i, j + 1], arr[i, j]);


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
Sorting(mass);
Print(mass);
