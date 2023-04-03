// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] newMatrix = CreateMatrix(4, 3, 0, 10);
PrintMatrix(newMatrix);
int [] arr = SumRow(newMatrix);
Console.WriteLine(string.Empty);
int minSum = MinSum(arr);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum + 1}");


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

int [] SumRow(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int [] array = new int[size];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                array[i] = array[i] + matrix[i, j];
            }  
        }
    return array;            
}

int MinSum(int[] array)
{
    int sum = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if(array[k] < array[sum]) sum = k;  
    }
    return sum; 
}