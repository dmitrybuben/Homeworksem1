// Задача 63: Сформировать трёхмерный массив с не повторяющимися двузначными числами
// и вывести его на экран построчно, с индексами элементов.

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"Индексы элемента {array[i, j, k]}: {i},{j},{k}; ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] matrix = new int[3, 4, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);