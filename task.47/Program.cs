﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] array = GeneratingAnArrayOfRealNumbers(3, 10); //Если хотите поменять массив просто впишите свои числа вместо (3, 4)
PrintArray(array);


double[,] GeneratingAnArrayOfRealNumbers(int m, int n)
{
    double[,] array = new double[m, n];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
