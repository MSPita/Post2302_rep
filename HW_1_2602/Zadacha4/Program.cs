Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int count = 2;
Console.WriteLine("Данное значение содержит следущие четные числа:");

while(count <= a)
{
    Console.WriteLine(count);
    count = count + 2;

}


