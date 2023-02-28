/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

//Инцилизация массива
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
//Печать массива
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
}
// Нахождение суммы в строках
int[] SummNumbersRows(int[,] matrix)
{
    int[] summRows = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            summRows[i] += matrix[i, j];

        }
    }
    return summRows;

}
// нахождение минимальной суммы
void IndexMinRows(int[] array)
{
    var minSummaIndex = 0;
    var minNumbers = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumbers)
            minSummaIndex = i + 1;
    }
    Console.Write($"Номер строки {minSummaIndex} с наименьшей суммой элементов в матрице ");
}
int[,] matrix = MatrixOfRandom(4, 6);
PrintMatrix(matrix);
IndexMinRows(SummNumbersRows(matrix));
