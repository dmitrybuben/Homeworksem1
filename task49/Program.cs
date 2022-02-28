// Показать двумерный массив размером m×n, заполненный вещественными числами.
void FillArray(double[,]matr)
{
    int k = new Random().Next(10, 100);
    Console.WriteLine("Коэффициент: " + k);

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(new Random().NextDouble() * k, 3);
            Console.Write($"{matr[i,j]} \t");
        }
        Console.WriteLine();
    }
}
double[,] matrix = new double[3, 4];
FillArray(matrix);