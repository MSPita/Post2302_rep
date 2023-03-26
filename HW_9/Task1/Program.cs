// Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все чётные натуральные числа 
//в промежутке от M до N с помощью рекурсии.

void EvenNum(int m, int n)
{
    if (m >= n) return;

    else if (n % 2 == 0)
    {
        EvenNum(m, n - 2);
        Console.Write($"{n}, ");
    }
    else if (n % 2 != 0)
    {
        n = n - 1;
        EvenNum(m, n - 1);
        Console.Write($"{n}, ");
    }

}


Console.Write("Введите первое число ряда: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ряда: ");
int n = int.Parse(Console.ReadLine()!);

EvenNum(m, n);
//Console.Write("Сумма чисел ряда: ");
//Console.Write(res);

