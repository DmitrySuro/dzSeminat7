/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] FillingArray(int rows, int columns)
{
    int[,] array = new int[rows,columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1,11);
        }
    }
    return array;
}

void PrintFillingArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

void AverageElementsColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        double average = sum / array.GetLength(1);
        System.Console.Write(average + " ");
    }
}

int[,] array = FillingArray(4,4);

PrintFillingArray(array);
AverageElementsColumns(array);