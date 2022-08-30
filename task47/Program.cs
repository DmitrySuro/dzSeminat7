/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

System.Console.Clear();

double[,] CreateNewArray(int rows, int columns)
{
    double[,] array = new double[rows,columns];
    var rand = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double m = rand.NextDouble()*10;
            double n = rand.NextDouble()*10;
            array[i,j] = m * n;
        }
    }
    return array;
}

void PrintNewArray(double[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]:f} ");
        }
        System.Console.WriteLine();
    }
}

double[,] array = CreateNewArray(3,4);

PrintNewArray(array);