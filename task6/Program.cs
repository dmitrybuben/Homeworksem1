﻿// Выяснить является ли число чётным
Console.Write("Введите целое число: ");

int num = int.Parse(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}