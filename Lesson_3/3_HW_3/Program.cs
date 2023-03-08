// Задача 3: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

void Kvad(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write(i*i*i +" ,");
    }
}

int x = int.Parse(Console.ReadLine()!);
Kvad(x);