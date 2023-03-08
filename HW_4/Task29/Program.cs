// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void massive(int mas)
{
    int[] numbers = new int[mas];
    for (int i = 0; i < mas; i++)
    {
        numbers[i] = new Random().Next(100);
        Console.WriteLine(numbers[i]);

    }
}
Console.WriteLine("Задайте длину массива ");
int length = int.Parse(Console.ReadLine()!);

massive(length);

