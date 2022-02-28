// Задать двумерный массив следующим правилом: Aₘₙ = m+n.
void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");           
        }
        Console.WriteLine();
    }
}
void ChangeArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i+j;
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,]matrix = new int[4,4];
FillArray(matrix);
Console.WriteLine();
ChangeArray(matrix);