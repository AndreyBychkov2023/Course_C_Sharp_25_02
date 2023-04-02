// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ValuesSet(int A, int B)
{
	if (B == 0) return 1;
	return ValuesSet(A, B - 1) * A;
}
	
int num_A = int.Parse(Console.ReadLine()!);
int num_B= int.Parse(Console.ReadLine()!);

Console.WriteLine(ValuesSet(num_A, num_B));