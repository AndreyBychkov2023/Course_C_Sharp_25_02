// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.


int TakeNum(int num)
{
    Console.WriteLine(num);
    return num / 10 % 10 ;
}

int result = TakeNum(new Random().Next(100,1000));
Console.WriteLine(result);


//int result = TakeNum(int.Parse(Console.ReadLine()));
//Console.WriteLine(result);
