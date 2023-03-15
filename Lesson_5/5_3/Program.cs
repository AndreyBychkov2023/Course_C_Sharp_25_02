// Задача 3: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


void Print(int[] arr)
	{
	    int size = arr.Length;
	
	    for (int i = 0; i < size; i++)
	        Console.Write($"{arr[i]} ");
	    Console.WriteLine();
	}
	
	int[] MassNums(int size, int from, int to)
	{
	    int[] arr = new int[size];
	
	    for (int i = 0; i < size; i++)
	        arr[i] = new Random().Next(from, to);
	    return arr;
	}
	
	int SumPosNeg(int[] arr)
	{
	    int num_2 = 0;
	
	    for (int i = 0; i < arr.Length; i++)
	    {
	        if (10 <= arr[i] && arr[i] <= 99)
	            num_2++;
	
	    }
	    return num_2;
	}

int num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	int[] mass = MassNums(num, start, stop);
	Print(mass);
	Console.WriteLine (SumPosNeg(mass));
