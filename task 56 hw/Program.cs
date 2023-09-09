// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

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

int [] SumInRows(int[,] matrix)
{
    int [] array = new int [matrix.GetLength(0)];
    int k = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix [i,j];
        }
         array [k] = sum;
         k++;
         sum = 0;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int NumberOfRowWithMinSum (int []array)
{
    int min = array[0];
    int indexMin = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k] < min)
        {
            min = array[k];
            indexMin = k;
        }
    }
    return indexMin + 1;
}


int[,] array2d = CreateMatrixRndInt(5,4,0,10);
PrintMatrix(array2d);
int [] arr = SumInRows (array2d);
PrintArray(arr);
int num = NumberOfRowWithMinSum(arr);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой {(num)}");
