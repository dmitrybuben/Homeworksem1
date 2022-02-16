// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран.

void FillArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}
void PrintArray(int[]collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");   
    }
    Console.WriteLine();
}
int[]arr = new int[10];
FillArray(arr);
PrintArray(arr);