// Покажите кубы чисел, заканчивающихся на чётную цифру.
int N = new Random().Next(1, 36);
Console.WriteLine("Граница интервала: " + N);
for (double i = 0; i <= N; i=i+2)
{
    Console.WriteLine($"Куб числа {i} равен {i*i*i}");
}