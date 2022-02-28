// В двумерном массиве показать позиции числа, заданного пользователем или указать, 
//что такого элемента нет.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(2, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FindElement(int[,] coll)
{
    int number = new Random().Next(1, 10);
    Console.WriteLine("Искомое число: " + number);
    bool valuefound = false;
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            if (coll[i,j] == number)
            {
                Console.WriteLine($"Позиция числа: ({i},{j}) ");
                valuefound = true;
            } 
        }
    }
    if (valuefound == false) Console.WriteLine("Искомого числа нет");    
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
FindElement(matrix);
