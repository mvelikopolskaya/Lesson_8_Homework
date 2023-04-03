// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);



void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j] < 10) Console.Write($"0{matr[i,j]} ");
            else Console.Write($"{matr[i,j]} ");
        }
            Console.WriteLine(string.Empty);
    }
}

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    int iMin = 0;
    int iMax = rows - 1;
    int jMin = 0;
    int jMax = columns - 1; 
    int i = 0;
    int j = 0;
    for (int count = 1; count <= matrix.Length; count++)
    {
        matrix[i, j] = count;
        if (i == iMin && j < jMax)
        {
            j++;
            if (j == jMax) iMin++;
        }
        else if(j == jMax && i < iMax)
        {
            i++;
            if (i == iMax) jMax--;
        }
        else if(i == iMax && j > jMin)
        {
            j--;
            if (j == jMin) iMax--;
        }
        else if(j == jMin && i > iMin)
        {
            i--;
            if (i == iMin) jMin++;
        }
    }
    return matrix;
}