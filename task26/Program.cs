// Возведите число А в натуральную степень B, используя цикл.

int DEG(int a, int b)
{
    int deg = a;

if (a == 0) return deg;
if (b == 0) return 1;
else
    for (int i = 2; i < b + 1; i++)
    {
        deg = a * deg;
    }
return deg;
}
int A = new Random().Next(-10, 10); Console.WriteLine("Случайное число: " + A);
int B = new Random().Next(0, 10); Console.WriteLine("Искомая степень числа: " + B);
Console.WriteLine($"Число {A} в степени {B}: " + DEG(A, B));