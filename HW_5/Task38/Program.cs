// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] Nums(int size, double from, double to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round(new Random().NextDouble() * (from - to) + to , 2);
    return arr;
}

void Dif(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) 
            max = arr[i];
        else if (arr[i] < min) 
            min = arr[i];
        i++;
        
    }
    double result = max - min;

    Console.WriteLine($"Разность -> ({max} - {min}) = {Math.Round(result), 2}");
    
}

Console.WriteLine("Задайте размер массива ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте начало массива ");
double start = double.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте конец массива ");
double stop = double.Parse(Console.ReadLine()!);

double[] mass = Nums(num, start, stop);
Print(mass);
Dif(mass);