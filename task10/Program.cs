// Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра: " + (num % 100) / 10);