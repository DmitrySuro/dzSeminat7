/*
Задача 50. Напишите программу, которая на вход принимает позиции
 элемента в двумерном массиве, и возвращает значение этого 
 элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

System.Console.Clear();

int[,] FillingArray(int rows, int columns,int minRandomValue, int maxRandomValue)
{
    int[,] array = new int[rows,columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(minRandomValue,maxRandomValue + 1);
        }
    }  
    return array;
}

void SearchPositionInArray(int[,] array, int userPositionColumns,int userPositionRows)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == userPositionRows && j == userPositionColumns)
            {   System.Console.WriteLine("Значение есть и оно равно " +
                                        array[userPositionRows,userPositionColumns]);            
            }
        }
    }
}

void IfNotUserPositonInArray(int[,] array, int userPositionColumns,int userPositionRows)
{
    if (userPositionColumns < 0 | userPositionColumns >= array.GetLength(1) |
        userPositionRows < 0 | userPositionRows >= array.GetLength(0))
    {
        System.Console.WriteLine("Нет такой позиции в массиве");
    }
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

System.Console.WriteLine("Введите позицию в массиве");
int userPositionRows = int.Parse(Console.ReadLine()!);
int userPositionColumns = int.Parse(Console.ReadLine()!);

int[,] array = FillingArray(4,4,1,9);

PrintFillingArray(array);

SearchPositionInArray(array,userPositionColumns,userPositionRows);
IfNotUserPositonInArray(array,userPositionColumns,userPositionRows);