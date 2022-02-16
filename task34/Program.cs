// Написать программу для замены элементов массива на противоположные.
void FillArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
}
void PrintArray(int[]coll)
{
    for (int j = 0; j < coll.Length; j++)
    {
        Console.Write($"{coll[j]} ");
    }
    Console.WriteLine();
}
void PrintChangedArray(int[]collection)
{
    for (int n = 0; n < collection.Length; n++)
    {
        collection[n] = collection[n] * (-1);
        Console.Write($"{collection[n]} ");
    }
    Console.WriteLine();
}

int[]num = new int[10];
FillArray(num);
PrintArray(num);
PrintChangedArray(num);