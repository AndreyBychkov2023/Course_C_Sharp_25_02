// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3   78 -> 2   89126 -> 5.

int SumNum(int num)
{
    int kol = 0;
    for (int i = 1; num > 0; i++)
    {
        num = num / 10;
        kol = i;
    }
    return kol;
}
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(A));