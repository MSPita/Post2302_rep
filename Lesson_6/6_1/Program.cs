// напишите программу, которая принимапет на вход 
//три числа и проверяет, может ли сущетвовать треугольник 
// со сторонами такой длины. (Длина стороны меньше суммы длин 2 других)

void Triangle(int A, int B, int C)
{
    if (A < B + C & B < A + C & C < A + B)
        Console.WriteLine("Yes");

    else
        Console.WriteLine("No");

}
int N1 = int.Parse(Console.ReadLine()!);
int N2 = int.Parse(Console.ReadLine()!);
int N3 = int.Parse(Console.ReadLine()!);

Triangle(N1, N2, N3);
