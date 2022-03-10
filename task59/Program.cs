// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write($"{array[i,j]}\t");
        }        
        Console.WriteLine();
    }
}
void RowMinSum(int[,] array)
{
    int summ = 0;
    int minsum = 0;
    int minindex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i,j];
        }
        Console.Write($"Сумма строки с индексом {i} = {summ}");
        Console.WriteLine();
        if(i == 0)
        {
            minsum = summ;
        }
        else
        {
            if(summ < minsum) 
            {
                minsum = summ;
                minindex = i+1;
            }
        }
    }
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {minindex}");
}
int[,]matrix = new int[3,4]; 
FillArray(matrix);
Console.WriteLine();
RowMinSum(matrix);