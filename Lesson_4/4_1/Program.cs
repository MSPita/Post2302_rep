// // Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int Sumnum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
        all_sum += i;
    return all_sum;

}

int A = int.Parse(Console.ReadLine()!);
int result = Sumnum(A);
Console.WriteLine(result);
