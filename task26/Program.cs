// Возведите число А в натуральную степень B, используя цикл.

// Решение 1.
/*int A = new Random().Next(-10, 10);
Console.WriteLine("Случайное число: " + A);
int B = new Random().Next(1, 10);
Console.WriteLine("Искомая степень числа: " + B);
int degree = A;

if (A == 0)
{
    Console.WriteLine($"Число {A} в степени {B} = 0");
}
else
{
    for (int I = 2; I < B + 1; I++)
    {
        degree = A * degree;
    }
    Console.WriteLine($"число {A} в степени {B} = {degree}");
}*/

// Решение 2.
int DEG(int a, int b)
{
    int deg = a;

if (a == 0) return deg;
else
    for (int i = 2; i < b + 1; i++)
    {
        deg = a * deg;
    }
return deg;
}
int A = new Random().Next(-10, 10); Console.WriteLine("Случайное число: " + A);
int B = new Random().Next(1, 10); Console.WriteLine("Искомая степень числа: " + B);
Console.WriteLine($"Число {A} в степени {B}: " + DEG(A, B));