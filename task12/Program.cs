// Удалить вторую цифру трехзначного числа.
int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное трехзначное число: " + number);
int first = number / 100;
int third = (number % 10);
Console.WriteLine("Случайное число без второй цифры: " + first + third);