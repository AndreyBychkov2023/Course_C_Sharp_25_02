// Задача 2: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string convert(int num)
{
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}
int num = int.Parse(Console.ReadLine()!);
string result = convert(num);
Console.WriteLine(result);