/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

//инцилизация массива
int[,] MatrixOfRandom(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }

    return matrix;
}
//печать массива
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
      Console.WriteLine(" ");
}
//умножение  матрицы
int[,] ProductOfMatrix(int[,] festMatrix, int[,]secondMatrix)
{
    int[,]thirtyMatrix=new int[festMatrix.GetLength(0),festMatrix.GetLength(1)];
    for (int i = 0; i < festMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < festMatrix.GetLength(1); j++)
    {
        for (int z = 0; z< festMatrix.GetLength(0)-1; z++)
        {
              thirtyMatrix[i,j]=festMatrix[i,z]*secondMatrix[z,j];
        }
    }
    }

    return thirtyMatrix;
}

int[,]festMatrix=MatrixOfRandom(3,3);
int[,]secondMatrix=MatrixOfRandom(3,3);
PrintMatrix(festMatrix);
PrintMatrix(secondMatrix);
PrintMatrix(ProductOfMatrix(festMatrix,secondMatrix));