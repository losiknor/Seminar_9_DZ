// Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
// M = 1; N = 4 -> 10
// M = 4; N = 8. -> 30
int SumNumber(int m, int n)
{
    if (n < m) return 0;
    return SumNumber(m, n-1) + n;
}
// SumNumber(new Random().Next(20, 99), new Random().Next(1, 19));
Console.Write(SumNumber(2,8));
