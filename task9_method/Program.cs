// Показать последнюю цифру трехзначного числа
/*Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
num = num % 10;
Console.WriteLine("Последняя цифра числа: " + num);
*/

// Показать последнюю цифру трехзначного числа

int LastNumber(int arg)
{
    return arg % 10;
}
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра введенного числа: " + LastNumber(number));