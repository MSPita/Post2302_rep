// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int Div(int a, int b)
{
    int pro = 1;
    for(int i = 0; i < b; i++)
    
        pro *= a;

    return pro;
}

Console.Write("Введите число А -> ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B -> ");
int B = int.Parse(Console.ReadLine()!);

int result = Div(A, B);

Console.Write("А в степени В -> ");
Console.Write(result);

