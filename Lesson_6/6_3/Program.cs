// не использую рекурсию, выведите первые N чисел
// Фибоначчи. Первые два сила Фибоначчи: 0 и 1.

void Fib(int a)
{
    int festNum = 0;
    int secondNum = 1;
    for (int i = 0; i < a; i++)
    {
        Console.Write(festNum + " ");
        (festNum, secondNum) = (secondNum, secondNum + festNum);

    }
}
int A = int.Parse(Console.ReadLine()!);
Fib(A);

