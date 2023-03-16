// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Nums(int m)
{
    int[] arr = new int[m];
    
    for (int i = 0; i < m; i++)
    {
        if(i<m)
        Console.Write("Введите любое число");
        int num = int.Parse(Console.ReadLine()!);

    }
        
    return arr;
}

int Even(int[] arr)
{
    int ev = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            ev = ev + 1;
        
    }
    Console.WriteLine($"Четных чисел -> {ev}");
    return ev;
}


Console.WriteLine("Задайте размер массива ");
int num = int.Parse(Console.ReadLine()!);

int[] mass = Nums(num);
Print(mass);
Even(mass);
