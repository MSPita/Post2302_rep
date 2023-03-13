// Задача 36. Задайте одномерный массив заполненный случайными числами.
// найдите сумму элементов,стоящих на нечетных позициях. 


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Nums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int OddNum(int[] arr)
{
    int sumodd = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 1)
            sumodd +=arr[i];
        
    }
    Console.WriteLine($"Сумма нетных чисел -> {sumodd}");
    return sumodd;
}

Console.WriteLine("Задайте размер массива ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте начало массива ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте конец массива ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = Nums(num, start, stop);
Print(mass);
OddNum(mass);

