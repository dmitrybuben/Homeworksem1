// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number <100) 
{
    Console.WriteLine("Число не имеет третьей цифры");
}
else
{
    while(number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine("Третья цифра числа: " + number % 10);
}