// Задача 67: Показать натуральные числа от N до 1, N задано.
// N = 5. -> "5, 4, 3, 2, 1"
void ShowNumber(int n)
{
    if (n < 1) return;
    
    Console.Write(n + " ");
    ShowNumber(n - 1);
}
ShowNumber(new Random().Next(10, 99));
