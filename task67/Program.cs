// Задача 67: Показать натуральные числа от N до 1, N задано.
//N = 5. -> "5, 4, 3, 2, 1"

int Show (int n)
{
    if( n == 0) return 0;
    Console.WriteLine(n);
    return Show(n-1);
}
Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("Вы ввели не натуральное число");
}
else Show(n);
