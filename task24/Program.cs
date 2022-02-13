// Найти кубы чисел от 1 до N
int N = new Random().Next(1, 10);
Console.WriteLine("N: " + N);
for(int i = 1; i < N+1; i ++)
{
    Console.WriteLine($"Куб числа {i}: {i*i*i}");
}