// Задача 20: Задать номер четверти, показать диапазоны для возможных координат.
int Range(int num)
{
if (num == 1)
{
    Console.WriteLine("Диапазоны возможных координат: x > 0, y > 0");
} 
else if(num == 2)
{
    Console.WriteLine("Диапазоны возможных координат: x < 0, y > 0");
}
else if(num == 3)
{
    Console.WriteLine("Диапазоны возможных координат: x < 0, y < 0");
}
else if(num == 4)
{
    Console.WriteLine("Диапазоны возможных координат: x > 0, y < 0");
}
return num;
}

int qternumber = new Random().Next(1, 4);
Console.WriteLine("Номер четверти: " + Range(qternumber));


/*int qternumber = new Random().Next(1, 4);
Console.WriteLine("Номер четверти: " + qternumber);

if (qternumber == 1)
{
    Console.WriteLine("Диапазоны возможных координат: x > 0, y > 0");
} 
else if(qternumber == 2)
{
    Console.WriteLine("Диапазоны возможных координат: x < 0, y > 0");
}
else if(qternumber == 3)
{
    Console.WriteLine("Диапазоны возможных координат: x < 0, y < 0");
}
else if(qternumber == 4)
{
    Console.WriteLine("Диапазоны возможных координат: x > 0, y < 0");
}
*/