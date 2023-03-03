// Напишите программу, которая принимает на вход трехзначное число
// и на выходе удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

void Div(int a)
{
    int result = (a - a % 100) / 10 + a % 10;
    Console.WriteLine(result);

}
Div(num);
