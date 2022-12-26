// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine("!Произведение двух матриц возможно, если количество столбцов первой равно количеству строк второй!");
int rows = InputNumbers("Введите число строк матрицы № 1: ");
int columnsRows = InputNumbers("Введите число столбцов матрицы № 1(строк матрицы № 2): ");
int columns = InputNumbers("Введите число столбцов матрицы № 2: ");

int[,] matrix1 = GetMatrix(rows, columnsRows);
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = GetMatrix(columnsRows, columns);
PrintMatrix(matrix2);
Console.WriteLine();

int[,] matrixResult = new int[rows, columns];
MultiplyMatrix(matrix1, matrix2, matrixResult);
PrintMatrix(matrixResult);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()!);
  return output;
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixResult)
{
  for (int i = 0; i < matrixResult.GetLength(0); i++)
  {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
      int sum = 0;
      for (int m = 0; m < matrix1.GetLength(1); m++)
      {
        sum += matrix1[i,m] * matrix2[m,j];
      }
      matrixResult[i,j] = sum;
    }
  }
}

void PrintMatrix(int[,] inArray)
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