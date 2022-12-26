/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


int[,] array = GetArray(3, 6, 1, 9);
PrintArray(array);
Console.WriteLine();
GetLeastSum(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void GetLeastSum(int[,] array)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        Console.WriteLine($"Строка № {i + 1}, сумма = {temp}");
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка № {index + 1} с наименьшей суммой элементов");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}