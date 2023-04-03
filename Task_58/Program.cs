// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int [,] firstMatrix = CreateMatrix(3, 2, 1, 10);
PrintMatrix(firstMatrix);
Console.WriteLine(string.Empty);
int [,] secondMatrix = CreateMatrix(2, 4, 1, 10);
PrintMatrix(secondMatrix);
Console.WriteLine(string.Empty);


if (MultiplicationPossibility(firstMatrix, secondMatrix)) 
{
    int[,] multipleMatrix = MultipleMatrix(firstMatrix, secondMatrix);
    PrintMatrix(multipleMatrix);
}
else
    Console.WriteLine("Матрицы невозможно перемножить");


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine(string.Empty);
    }    
}

int[,] MultipleMatrix(int[,] firstMatr, int[,] secondMatr)
{
    int rows = firstMatr.GetLength(0);
    int columns = secondMatr.GetLength(1);
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                matrix[i, j] = matrix[i, j] + firstMatr[i, k] * secondMatr[k, j]; 
            }
        }
    }
    return matrix;
}

bool MultiplicationPossibility(int[,] firstMatr, int[,] secondMatr)
{
    return firstMatr.GetLength(1) == secondMatr.GetLength(0);
}