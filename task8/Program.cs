// Показать четные числа от 1 до N
int N = new Random().Next(1, 20);
Console.WriteLine("Случайное число N: " + N);

int num = 2;

if(N < num) Console.WriteLine("Четных чисел нет");

Console.WriteLine("Четные числа:");

while(num < N)
{
    Console.WriteLine(num);
    num = num + 2;
}
if(num == N) Console.WriteLine(num);