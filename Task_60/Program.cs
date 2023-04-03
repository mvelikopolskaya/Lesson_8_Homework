// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[,,] array3d = CreateArray3D(2, 2, 2, 10, 100);
PrintArray3D(array3d);

int[,,] CreateArray3D(int rows, int columns, int depth, int min, int max)
{
    int[,,] arr3d = new int[rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                int temp = rnd.Next(min, max);
                while (IsUnique(arr3d, temp) == false)
                {
                    temp = rnd.Next(min, max);
                }
                arr3d[i, j, k] = temp;                                                           
            }
        }
    }
    return arr3d;
}

void PrintArray3D(int[,,] arr3d)
{
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k <arr3d.GetLength(2); k++)
            {
                Console.Write($"{arr3d[i, j, k],1}({i},{j},{k}) ");
            }
        }
            Console.WriteLine(string.Empty);
    }
}

bool IsUnique(int[,,] matr, int temp)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if(matr[i,j,k] == temp) return false;
            }
        }
    }
    return true;
}