// Пользователь вводит с клавиатуры М чисел.
// посчитайте, сколько положительных чисел ввнд пользователь.

int Pos(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел хотели бы ввести?: ");
int a = int.Parse(Console.ReadLine()!);
int result = Pos(a);
Console.WriteLine($"Количество чисел больше 0: {result}");
