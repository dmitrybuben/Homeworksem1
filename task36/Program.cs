/* Задать массив, заполнить случайными положительными трёхзначными числами. 
Показать количество нечётных/чётных чисел.
 */

void FillArray(int[]numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(99, 1000);
    }
}
void PrintArray(int[]arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + "\t");
    }
    Console.WriteLine();
}
void PrintSelected(int[]select)
{
    int evensumm = 0;
    int oddsumm = 0;
    for (int n = 0; n < select.Length; n++)
    {
        if(select[n] % 2 == 0)
        {
            evensumm++;
        }
        else
        {
            oddsumm++;
        }
    }
    Console.WriteLine("Количество четных элементов массива: " + evensumm);
    Console.WriteLine("Количество нечетных элементов массива: " + oddsumm);
}
int[]array = new int[10];
FillArray(array);
PrintArray(array);
PrintSelected(array);