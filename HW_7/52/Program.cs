//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

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

double[] ArithMean(int[,] arr)
{
    
    double[] mean = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            mean[j] += arr[i, j];
        mean[j] /= arr.GetLength(0);

    }
    return mean;
}

string PrintDoubleArr(double[] arr)
{
    string res = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        res += Math.Round(arr[i], 2);
        if (i != arr.Length - 1) res += ";";
        else res += ".";

    }
    return res;
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


double[] arith = ArithMean(mass);
string print = PrintDoubleArr(arith);

Console.WriteLine(print);

