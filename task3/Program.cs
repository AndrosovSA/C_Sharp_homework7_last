// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] CreatArrayRnd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void PrintReverseArray(int[] array, int size)
{
    if (size == 0) return;
    Console.Write($"{array[size - 1]} ");
    PrintReverseArray(array, size - 1);
}
Console.Write("Введите рамер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayResult = CreatArrayRnd(n, 10, 100);
Console.Write("Массив случайных чисел: ");
PrintArray(arrayResult);
Console.WriteLine();
Console.Write($"Развернутый массив:     ");
PrintReverseArray(arrayResult, n);
