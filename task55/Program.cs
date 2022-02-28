// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void ChangeArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        double average = 1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
            average = summ / array.GetLength(0);
        }
        Console.Write($"{average}\t");
    }
    Console.WriteLine();
}
int[,] matrix = new int[4, 4];
FillArray(matrix);
Console.WriteLine();
ChangeArray(matrix);