// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void Intersection(double k1, double b1, double k2, double b2)
{
    double k_sub = k1 - k2;

    if (k_sub != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка переcечения: ({x}; {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else
        Console.WriteLine("Нет точек пересечения");

}

double k_1 = double.Parse(Console.ReadLine()!);
double b_1 = double.Parse(Console.ReadLine()!);
double k_2 = double.Parse(Console.ReadLine()!);
double b_2 = double.Parse(Console.ReadLine()!);

Intersection(k_1, b_1, k_2, b_2);
