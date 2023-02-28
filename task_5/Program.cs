/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

//печать массива
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}
//спиральное заполение
int[,] SpiralMatrix(int[,] matrix)
{
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

    int count = 1;
    int i = 0;
    int j = 0;

    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = count;
        if (i == Ibeg && j < matrix.GetLength(1) - Jfin - 1)
            ++j;
        else if (j == matrix.GetLength(1) - Jfin - 1 && i < matrix.GetLength(0) - Ifin - 1)
            ++i;
        else if (i == matrix.GetLength(0) - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != matrix.GetLength(1) - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++count;
    }
    return matrix;
}

int[,] matrix = new int[4, 4];
PrintMatrix(SpiralMatrix(matrix));
