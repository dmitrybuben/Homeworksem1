// Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы

double b1 = new Random().Next(-10, 10);
Console.WriteLine("b1: " + b1);
double k1 = new Random().Next(-10, 10);
Console.WriteLine("k1: " + k1);
double b2 = new Random().Next(-10, 10);
Console.WriteLine("b2: " + b2);
double k2 = new Random().Next(-10, 10);
Console.WriteLine("k2: " + k2);

if (k1 == k2) Console.WriteLine("Прямые не имеют точек пересечения");

else
{
    double x = Math.Round((b2 - b1) / (k1 - k2),2);
    double y = Math.Round((k1 * x + b1),2);
    Console.WriteLine($"Координаты точки пересечения двух прямых: х = {x} y = {y}");
}