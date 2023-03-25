// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");

    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
        arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 3);// цифра 3 дает количество знаков после запятой
    
    return arr;
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
