// // 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

int N = int.Parse(Console.ReadLine()!);

void Div(int N)
{
    if (N % 7 == 0 & N % 23 == 0)
        Console.WriteLine("Кратно");

    else
        Console.WriteLine("Некратно");

}
//Console.WriteLine("Hello, World!");
Div(N);
