// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11   82 -> 10   9012 -> 12.


int SumNum(int num)
{
int result = 0;
for (int i = 0; num > 0; i++)
{
    result += num % 10;
    num = num / 10;
}
return result;

}
int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);





