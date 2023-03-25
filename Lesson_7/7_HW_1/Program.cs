// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void Print(double[,] arr) // поменял
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
    
double[,] MassNums(int row, int column, int from, int to) // поменял
{
    double[,] arr = new double[row, column]; // поменял
       Random new1 = new Random(); // добавил
    
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(new1.NextDouble() * (from + to) - from, 2); // Math.Round(n_new.NextDouble() * (from + to) - from, 2); //new Random().Next(from, to)

    return arr;
}
    
int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(num_row, num_column, start, stop);// поменял
Print(mass);