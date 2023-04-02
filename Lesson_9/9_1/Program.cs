//Задача 2: Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void ValuesSet(int M, int N)
{
	if (N < M) return;
	ValuesSet(M, N - 1);
	Console.Write($"{N} ");
}
	
int num_1 = int.Parse(Console.ReadLine()!);
int num_2= int.Parse(Console.ReadLine()!);
ValuesSet(num_1, num_2);