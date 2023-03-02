// Напишите программу, которая выводит случайное трехзначное число и
// удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int Div(int a)
{
    int result = (a - a % 100)  10 + a % 10;
    Console.WriteLine(result);
    return result;
}

Div(num);


