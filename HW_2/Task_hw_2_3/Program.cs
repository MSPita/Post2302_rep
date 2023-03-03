// напишите программу, которая выводит третью цифру числа или 
// сообщает, что третьей цифры нет.

int num = int.Parse(Console.ReadLine()!);


void Div(int a)
{
    Console.Write($"{num} -> ");

    if(a<100)
    {
        Console.WriteLine("Третьей цифры нет.");
        return;
    } 
    while(a > 999) a /= 10;
    Console.WriteLine(a % 10);

} 

Div(num);

