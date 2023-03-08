// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Write("Введите число -> ");
int A = int.Parse(Console.ReadLine()!);


void Div(int num)
{
    int sum = 0;
    for(int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;

    }
    Console.Write("Сумма цифр числа -> ");  
    Console.WriteLine(sum);
}


Div(A);
