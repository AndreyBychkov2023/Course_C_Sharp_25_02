// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


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
    
    int KolNum(int[] arr)
    {
        int pos = 0;
    
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                pos++;
        }
        return pos;
    } 
    
    int num = int.Parse(Console.ReadLine()!);
    int start = int.Parse(Console.ReadLine()!);
    int stop = int.Parse(Console.ReadLine()!);
    int[] mass = MassNums(num, start, stop);
    Print(mass);
    Console.WriteLine(KolNum(mass));