// Напищите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3Д пространстве.

double Dis(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));

}
Console.WriteLine(Math.Round(Dis(3, 6, 8, 2, 1, -7),2, MidpointRounding.AwayFromZero));
