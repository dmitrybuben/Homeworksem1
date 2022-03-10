// Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
//M = 1; N = 4 -> 10
//M = 4; N = 8. -> 30

Console.Clear();
int Summ(int m, int n)
{
    //if(m == n) return 0;
    
    if (m < n)
    {
        return m + Summ(m+1,n);       
    }
    else if (m > n)
    {
        return m + Summ(m-1,n);
    }
    return n;
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
if (m == n) Console.WriteLine("Сумма элементов: 0");
else
Console.WriteLine($"Сумма элементов от {m} до {n}: {Summ(m,n)}");