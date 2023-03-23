// Рекурсия
//https://www.youtube.com/watch?v=F4HNO4rCQ2c&ab_channel=KhanAcademyRussian
//https://youtu.be/rh1mP02NFoM?t=229
//https://skillbox.ru/media/code/rekursiya-vokrug-nas/
//
//Задайте занчение N. Напишите программу, которая
// выведет все натуральные числав промежутке
// от 1 до N при помощи рекурсии.

void SeriesNums(int N)
{

    if (N == 0) return;
    SeriesNums(N - 1);
    Console.Write($"{N}, ");

}

SeriesNums(int.Parse(Console.ReadLine()!));
