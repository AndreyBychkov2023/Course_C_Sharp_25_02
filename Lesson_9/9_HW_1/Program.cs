// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void ValuesSet(int M, int N)
{
    if (N < M) 
    {
        return;
    }
    else if (N > M && N % 2 == 0) 
    {
        ValuesSet(M, N - 2);
        Console.Write($"{N} ");
    }
    else if (N > M && N % 2 == 1) 
    {
        ValuesSet(M, N - 2);
        Console.Write($"{N - 1} ");
    }
}
    
int num_1 = int.Parse(Console.ReadLine()!);
int num_2= int.Parse(Console.ReadLine()!);
ValuesSet(num_1, num_2);