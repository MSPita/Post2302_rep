// Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

void Div(int a)
{
    int result = a / 10 % 10;
    Console.WriteLine(result);

}
Div(num);
