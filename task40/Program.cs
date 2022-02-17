// В указанном массиве вещественных чисел найти разницу между максимальным 
// и минимальным элементами.
void FillArray(double[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
}
void PrintArray(double[]coll)
{
    for (int j = 0; j < coll.Length; j++)
    {
        Console.Write(coll[j]+ "\t");
    }
    Console.WriteLine();
}
double MaxMinDifference(double[]massiv)
{
    double max = massiv[0];
    for (int n = 1; n < massiv.Length; n++)
    {
        if(massiv[n] > max) 
        {
            max = massiv[n];
        }
    }
    Console.WriteLine("Максимальный элемент: " + max);
    
    double min = massiv[0];
    for (int n = 1; n < massiv.Length; n++)
    {
        if(massiv[n] < min) 
        {
            min = massiv[n];
        }
    }
    Console.WriteLine("Минимальный элемент: " + min);
    double difference = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементом: " + difference);
    return difference;
}
double[]Collection = new double[5]; 
FillArray(Collection);
PrintArray(Collection);
MaxMinDifference(Collection);