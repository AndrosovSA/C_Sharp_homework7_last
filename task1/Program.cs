// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintIntervalNumbers(int n, int m)
{
    if (n == m - 1 || m == n - 1) return;

    if (n < m)
    {
        PrintIntervalNumbers(n, m - 1);
        Console.Write($"{m - 1} ");
    }
    if (n > m)
    {
        PrintIntervalNumbers(n - 1, m);
        Console.Write($"{n - 1} ");
    }

}
Console.Write("Введите первое натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());
if (N < 1 || M < 1)
{
    Console.WriteLine("Некорректный ввод!!!");
    return;
}
PrintIntervalNumbers(N, M);
