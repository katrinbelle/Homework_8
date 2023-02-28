// /* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66{0,0,0} 25{0,1,0}
// 34{1,0,0} 41{1,1,0}
// 27{0,0,1} 90{0,1,1}
// 26{1,0,1} 55{1,1,1} */

Dictionary<int, int> Slovar = new Dictionary<int, int>();
int[,,] matrix ={
                   {
                       {0,0,0},
                       {0,1,0}
                   },
                   {
                       {1,0,0},
                       {1,1,0}
                   },
                   {
                       {0,0,1},
                       {0,1,1}
                   },
                   {
                       {1,0,1},
                       {1,1,1}
                   }
               };
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0)*matrix.GetLength(1); i++)
{
   
        int oldRandom = rnd.Next(10, 100);
        if (Slovar.ContainsKey(oldRandom))
            oldRandom = rnd.Next(10, 100);
        else Slovar.Add(oldRandom, 1);
}

int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write($"{Slovar.ElementAt(count).Key}");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        count++;


        Console.Write("{");
        
string point=",";
        int z = 0;
        while (z < matrix.GetLength(2))
        {
            if(z==matrix.GetLength(2)-1)
point="";

            int oldRandom = rnd.Next(10, 100);
            if (Slovar.ContainsKey(oldRandom))
                oldRandom = rnd.Next(10, 100);

            else Slovar.Add(oldRandom, i);

            Console.Write($"{matrix[i, j, z]}{point}");
            z++;

        }

        if (j >= matrix.GetLength(1) - 1)
            Console.Write("}");
        else
        {
            Console.Write("} "+ Slovar.ElementAt(count).Key);
            count++;
        }

    }

    Console.WriteLine("");
}