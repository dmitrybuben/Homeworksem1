// Даны два числа. Показать большее и меньшее число
Console.Write("Введите первое целое число: ");

int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");

int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Наибольшее число: " + num1);
    Console.WriteLine("Наименьшее число: " + num2);
}
else if(num1 < num2)
{
    Console.WriteLine("Наибольшее число: " + num2);
    Console.WriteLine("Наименьшее число: " + num1);
}
else
{
    Console.WriteLine("Введите два разных числа");
}