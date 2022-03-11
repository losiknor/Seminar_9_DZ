// Задача 71: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 3 -> A(m,n) = 29
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    {
        if (m > 0 && n == 0)
            return Akkerman(m - 1, 1);
        else
        {
            if (m > 0 && n > 0)
                return Akkerman(m - 1, Akkerman(m, n - 1));
            else return 0;
        }
    }
}
Console.WriteLine(Akkerman(m, n));
