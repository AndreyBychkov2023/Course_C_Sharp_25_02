// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


// Задача 3: Задайте двумерный массив. Найдите сумму элементов
// главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
     
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
    
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int SumMass (int [,] arr)
{
    int summarr = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) summarr = summarr + arr[i, j];
        }
    return summarr;
}

Console.WriteLine("Введите количество строк массива");    
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int num_column = int.Parse(Console.ReadLine()!);
int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
int sum = SumMass(mass);
Console.WriteLine($"Summa: {sum}");
