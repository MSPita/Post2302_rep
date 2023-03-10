// Задача 34. Задайте массив заполненный случайными трехзначными числами.
//Напишите программу, которая покажет количество четных чисел в массиве.


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Nums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

void Even(int[] arr)
{
    int ev = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            ev = ev + 1;
        
    }
    Console.WriteLine($"Четных чисел -> {ev}");
}

Console.WriteLine("Задайте размер массива ");
int num = int.Parse(Console.ReadLine()!);

int[] mass = Nums(num);
Print(mass);
Even(mass);
