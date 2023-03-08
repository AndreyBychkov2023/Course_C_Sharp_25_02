﻿// Задача 2: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Example (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2) +Math.Pow(z2-z1, 2));
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
int num_3 = int.Parse(Console.ReadLine()!);
int num_4 = int.Parse(Console.ReadLine()!);
int num_5 = int.Parse(Console.ReadLine()!);
int num_6 = int.Parse(Console.ReadLine()!);
Example(num_1, num_2, num_3, num_4, num_5, num_6);
Console.WriteLine(Example(num_1, num_2, num_3, num_4, num_5, num_6));

//Console.WriteLine(Example(3, 6, 8, 2, 1, -7));
//Console.WriteLine(Example(7, -5, 0, 1, -1, 9));
