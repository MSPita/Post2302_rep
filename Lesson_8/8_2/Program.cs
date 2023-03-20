// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

bool Check(int row, int column)
{   

    bool result = row != column;
    return result;
}

string RowToColumn(int[,] array)
{
    if (Check(array.GetLength(0), array.GetLength(1))) return "Нет!";

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    PrintArray(array);
    return "Да!";
}