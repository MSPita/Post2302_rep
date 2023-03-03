//   Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

int num = int.Parse(Console.ReadLine()!);

void Div(int n)
{
    if(n == 7 || n ==6)
    Console.WriteLine("Выходной день");

    else if(n < 6 & n > 0)
    Console.WriteLine("Рабочий день");

    else 
    Console.WriteLine("не день недели");
}

Div(num);


