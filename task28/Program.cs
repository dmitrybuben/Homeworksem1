// Подсчитайте сумму цифр в числе.
int summ(int n)
{
    int s = 0;
    if(n == 0)
    {
        return s;
    }
    else if (n < 0)
    {
        n = n * (-1);
    }
    while (n > 0)
    {
        s = s + n % 10;
        n = n / 10;
    }
    return s;
}
int N = new Random().Next(-1000, 1000);
Console.WriteLine("Случайное число: " + N);
Console.WriteLine("Сумма цифр в числе: " + summ(N));
