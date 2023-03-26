//  Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.



int SumNum(int M, int N)
{
    
    if (M == N) return M;
    else return N + SumNum(M, N - 1);

}

Console.Write("Введите первое число ряда: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ряда: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Сумма чисел ряда: ");
Console.WriteLine (SumNum(m, n));

