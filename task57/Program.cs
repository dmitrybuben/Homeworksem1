//Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
void PrintArray(int[,] array)
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
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        for (; j < array.GetLength(1)-1; j++)
        {
            int max = array[i,j];

            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i,k] > max)
                {
                    max = array[i,k];
                    int temp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = temp;
                }
            }
            Console.Write($"{array[i,j]}\t");
        }
        Console.Write(array[i,j]);
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix);