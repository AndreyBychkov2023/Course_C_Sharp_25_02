// Задача 2: Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

void Example (int [,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 1; j < arr.GetLength(1); j = j + 2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
Example(mass);
Print(mass);