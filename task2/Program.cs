// Функция Аккермана

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Ack(n - 1, 1);
    return Ack(n - 1, Ack(n, m - 1));
}
Console.Write("Введите первый параметр функции Аккермана n: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй параметр функции Аккермана m: ");
int M = Convert.ToInt32(Console.ReadLine());
int result = Ack(N, M);
Console.Write($"A({N},{M}) = ");
Console.Write(result);