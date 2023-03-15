// напишите программу, которая будет создавать копию заданного 
//массива с помощью поэлементного копирования.

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();// для перехода на новую строчку
    }

    }

int[,] FilMass(int row, int columns, int from, int to)
{
    int[,] Array = new int[row, columns];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array[i, j] = new Random().Next(from, to);
        }
    }
    return Array;
}

int[,] CopyMass(int[,] arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,] newArr = new int[row, columns];


    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArr[i, j] = arr[i, j];
        }
    }
    return newArr;
}
    

int[,] mass = FilMass(3, 4, 1, 11);
Print(mass);

Console.WriteLine();

int[,]mass2 = CopyMass(mass);
Print(mass2);