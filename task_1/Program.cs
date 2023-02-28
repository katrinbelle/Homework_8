/*  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

//Получение от пользователя числа

string[] GetNumbersOfUser(string messenge)
{
    Console.Write(messenge);
    char[] delimiter = new char[] { ' ', ',', '.' };
    string[] splitArray = Console.ReadLine()!.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
    return splitArray;
}

//Получение чисел из строки
int[] GetArray(string[] splitArray)
{
    int[] newArray = new int[splitArray.Length];
    int result = 0;
    for (int i = 0; i < splitArray.Length; i++)
    {
        if (int.TryParse(splitArray[i], out result))
            newArray[i] = result;
        else Console.Write("Ввеедите число ");
    }
    return newArray;
}


//Инцидизация массива рандомом
int[,] GetMatrixOfRandoms(int[] newArray)
{
    int[,] matrix = new int[newArray[0], newArray[1]];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

// Упорядочивание строк массива
int[,] DescetingRows(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                if (matrix[j, z] < matrix[j, z + 1])
                {
                    int temporary = matrix[j, z + 1];
                    matrix[j, z + 1] = matrix[j, z];
                    matrix[j, z] = temporary;
                }

            }
        }
    }

    return matrix;
}
//Печать массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}

int[,] matrix = GetMatrixOfRandoms(GetArray(GetNumbersOfUser("Введите размер массива ")));
PrintMatrix(matrix);
PrintMatrix(DescetingRows(matrix));