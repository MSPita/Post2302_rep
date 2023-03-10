// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Оформите вывод и заполнение в виде функции.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");

    Console.WriteLine();
}


int[] Mass(int size, int from, int to)
{
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
        numbers[i] = new Random().Next(from, to);
    return numbers;    
    
}

Console.WriteLine("Задайте размер массива ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте начало массива ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте конец массива ");
int stop = int.Parse(Console.ReadLine()!);

int[]mass = Mass(num, start, stop);
Print(mass);


