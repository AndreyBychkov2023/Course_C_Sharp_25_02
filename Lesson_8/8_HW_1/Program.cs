// Задача 1: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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
	      arr[i, j] = new Random().Next(from, to + 1);
	
	return arr;
}

void SelectionSort(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            for (int k = 0; k < column_size - j - 1; k++)
                if (arr[i, k] < arr[i, k + 1])
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
        }
    }
}

Console.WriteLine("Введите количество строк массива");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число в массиве");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максимальное число в массиве");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
SelectionSort(mass);
Print(mass);