// Задача 3: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void Massiv(int leght)
{
    int[] Ar = new int[leght];
    for (int i = 0; i < leght; i++)
    {
        Ar[i] = new Random().Next(2);
        Console.WriteLine(Ar[i]);
    }
}

Massiv(int.Parse(Console.ReadLine()!));