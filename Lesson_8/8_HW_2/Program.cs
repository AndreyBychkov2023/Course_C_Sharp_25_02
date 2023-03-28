// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
	int row_size = arr.GetLength(0);
	int column_size = arr.GetLength(1);
	
	for (int i = 0; i < row_size; i++)
	{
	  for (int j = 0; j < column_size; j++)
	    Console.Write($" {arr[i, j],4} ");
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

int[] SumNum(int[,] arr)
{
	int row = arr.GetLength(0);
	int column = arr.GetLength(1);
    int[] all_nums = new int[row];
	
	for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            all_nums[i] += arr[i, j];
        }
    }
	return all_nums;
}

void FindMin(int[] arr)
{
    int min_num = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[min_num]) min_num = i;
    }
    Console.WriteLine($"Строка № {min_num + 1} является строкой с наименьшей суммой элементов, равной: {arr[min_num]}");
}

Console.WriteLine("Введите количество строк массива");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int column_num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Задайте минимальное число в массиве");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максимальное число в массиве");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

FindMin(SumNum(mass));
