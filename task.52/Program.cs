/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
//как сделать как чтобы не самому вводить массив а он генерировался рандомно 

Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = int.Parse(Console.ReadLine());

int[,] number = new int[n, m];
FillArrayRandomNumbers(number);
PerformsCalculationOfArithmeticMeanNumber(number);
//выполняет подсчет средне арифметического числа
void PerformsCalculationOfArithmeticMeanNumber(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double res;

    for (int i = 0; i < column; i++)
    {
        res = 0;
        for (int j = 0; j < row; j++) res += arr[j, i];
        Console.Write($"{Math.Round(res / row, 2)}; ");
    }
}
//Заполняет массив случайными числами
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
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