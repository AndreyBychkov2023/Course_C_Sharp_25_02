// Задача 2: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
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
    
string FindEl(int[,] arr, int num_1, int num_2)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (num_1 > row || num_1 <= 0 || num_2 > column || num_2 <= 0)
        return $" {num_1} {num_2} -> числа c таким номером позиции нет в массиве";
    return $"[{num_1}, {num_2}] = {arr[num_1 - 1, num_2 - 1]} -> число c таким номером позиции есть в массиве";
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

Console.WriteLine("Введите номер позиции строки массива");  
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер позиции столбца массива");  
int num_2 = int.Parse(Console.ReadLine()!);

string answer = FindEl(mass, num_1, num_2);
Console.WriteLine(answer);  