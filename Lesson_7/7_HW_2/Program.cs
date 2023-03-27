// Задача 2: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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
    
    void SumPosNeg(int[] arr, int num_1)
    {
    
    
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num_1) 
            {
              Console.WriteLine("Да");
              return;
            }
        }
        Console.WriteLine("Нет");
    }
    
    
    int num = int.Parse(Console.ReadLine()!);
    int start = int.Parse(Console.ReadLine()!);
    int stop = int.Parse(Console.ReadLine()!);
    int num_1 = int.Parse(Console.ReadLine()!);
    int[] mass = MassNums(num, start, stop);
    Print(mass);
    SumPosNeg(mass, num_1);