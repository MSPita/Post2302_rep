Console.WriteLine("введите ваше число");
int a = int.Parse(Console.ReadLine()!);
if(a == 1)
{
    Console.WriteLine("Montag");
}
else if(a == 2)
{
    Console.WriteLine("Dinstag");
}

else if(a == 3)
{
    Console.WriteLine("Mitwoch");
}

else if(a == 4)
{
    Console.WriteLine("Donerstag");
}

else if(a == 5)
{
    Console.WriteLine("Freitag");
}

else if(a == 6)
{
    Console.WriteLine("Sondabend");
}

else if(a == 7)
{
    Console.WriteLine("Sontag");
}

else
{
    Console.WriteLine("false");
}
