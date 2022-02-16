// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
void FillArray(int[]numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[]collect)
{
    for (int j = 0; j < collect.Length; j++)
    {
        Console.Write($"{collect[j]} ");
    }
    Console.WriteLine();
}
int ElementsSum(int[]array)
{
    int summ = 0;
    for (int n = 1; n < array.Length; n=n+2)
    {
        summ = summ + array[n];
    }
    Console.WriteLine("Сумма чисел массива, стоящих на нечетной позиции: " + summ);
    return summ;
}
int[]massiv = new int[10];
FillArray(massiv);
PrintArray(massiv);
ElementsSum(massiv);









