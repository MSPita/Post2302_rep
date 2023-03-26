// Задача 58: Задайте две матрицы. Напишите программу, которая 
//будет находить произведение двух матриц.
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
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;

}
int[,] MatrixMult(int[,] arr_a, int[,] arr_b)
{
    int row_a = arr_a.GetLength(0);
    int column_a = arr_a.GetLength(1);

    int row_b = arr_b.GetLength(0);
    int column_b = arr_b.GetLength(1);
    int[,] matrix_new = new int[row_a, column_a];

    if (column_a != row_b) return matrix_new;
        
       
    else if (column_a == row_b)
        matrix_new = new int[row_a, column_b];

    for (int i = 0; i < row_a; i++)
    {
        for (int j = 0; j < column_b; j++)
        {
            for (int p = 0; p < column_a; p++)
                matrix_new[i, j] += arr_a[i, p] * arr_b[p, j];
        }
    }
    return matrix_new;

}
Console.Write("Количество строк первой матрицы-> ");
int row_a = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов первой матрицы-> ");
int column_a = int.Parse(Console.ReadLine()!);

Console.Write("Количество строк второй матрицы-> ");
int row_b = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов второй матрицы-> ");
int column_b = int.Parse(Console.ReadLine()!);

Console.Write("Начало диапазона -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапазона -> ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] arr_1 = Massiv(row_a, column_a, start, stop);
Print(arr_1);
int[,] arr_2 = Massiv(row_b, column_b, start, stop);
Print(arr_2);

int[,] res_matrix = MatrixMult(arr_1, arr_2);
Print(res_matrix);

