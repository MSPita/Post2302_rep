//напишите программу, которая принимает на вход число N
// и выдает таблицу кубов чисел от 1 до N.

int num = int.Parse(Console.ReadLine()!);

void Div(int n)
{
    int i = 1; 
    while(i <= n)
    {
      Console.WriteLine(Math.Pow(i, 3));
      i++;

    }
}
Div(num);

