// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Write("Введите число -> ");
int A = int.Parse(Console.ReadLine()!);


void SumNum(int num)
{
    int sum = 0;
    for(int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;

    }
        

}


SumNum(A);

//Console.WriteLine();

//Console.Write("");
//Console.Write(result);

//Console.WriteLine("Hello, World!");
