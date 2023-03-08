// напишите программу, котрая принимает на вход число N и
//  выдает произведение чисел от 1 до N

int CompositionNum(int num)
{
    int multiply = 1;
    for (int i = 1; num >= i; i++)
    
        multiply *= i;
        
    return multiply;
    
}

int N = int.Parse(Console.ReadLine()!);

int result = CompositionNum(N);

Console.WriteLine(result);

