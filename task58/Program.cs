//  Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.



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

bool CheckMatrix (int [,] matrix1, int [,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int [,] MultiplicationMatrix (int [,] matrix1, int [,] matrix2)
{
    int [,] matrixResult = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
       matrixResult [i,j] = 0;
       for (int k = 0; k < matrix1.GetLength(1); k++)
       {
        matrixResult [i,j] += matrix1 [i,k] * matrix2 [k,j];
       }

    }
}
return matrixResult;
}


int[,] array2d = CreateMatrixRndInt(2, 2, 0, 10);
int [,] array2dTwo = CreateMatrixRndInt (2,2,0,10);
PrintMatrix(array2d);
Console.WriteLine();
PrintMatrix(array2dTwo);
Console.WriteLine();
if (!CheckMatrix (array2d, array2dTwo)) 
{
    Console.WriteLine("Умножение невозможно");
    return;
}
int [,] resultArray = MultiplicationMatrix (array2d, array2dTwo);
PrintMatrix(resultArray);

