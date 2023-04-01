// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void Print(double[,] arr) 
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
     
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j], 6} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
    
double[,] MassNums(int row, int column, int from, int to) 
{
    double[,] arr = new double[row, column];
       Random new1 = new Random();
    
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(new1.NextDouble() * (from + to) - from, 2);
    return arr;
}

Console.WriteLine("Введите количество строк массива");    
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int num_column = int.Parse(Console.ReadLine()!);

Console.WriteLine("Задайте минимальное число в массиве");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максимальное число в массиве");
int stop = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
