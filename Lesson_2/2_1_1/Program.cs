//Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает последнюю цифру этого числа.

// Вариант 2. Функция (примороченный).

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;

}

int result = TakeNum (new Random().Next(100, 1000));

Console.WriteLine(result);

