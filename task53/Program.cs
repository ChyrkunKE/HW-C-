// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

void ReplaceFirstLastLists(int [,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0)-1;
    int columns = matrix.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
       int temp = matrix[firstRow,j];
       matrix [firstRow,j] = matrix[lastRow,j];
       matrix[lastRow,j] = temp;
    }
}

int[,] array2d = CreateMatrixRndInt(5,5,0,10);
PrintMatrix(array2d);
ReplaceFirstLastLists(array2d);
Console.WriteLine();
PrintMatrix(array2d);
