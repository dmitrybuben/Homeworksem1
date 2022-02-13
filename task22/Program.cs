// Найти расстояние между точками в пространстве 2D/3D
/*
Console.WriteLine("Введите 2, если ищем в 2D или 3, если ищем в 3D");
int variant = int.Parse(Console.ReadLine());
if (variant == 2)
{
    int xa = new Random().Next(-10, 10); Console.WriteLine("xa:" + xa);
    int ya = new Random().Next(-10, 10); Console.WriteLine("ya:" + ya);
    int xb = new Random().Next(-10, 10); Console.WriteLine("xb:" + xb);
    int yb = new Random().Next(-10, 10); Console.WriteLine("yb:" + yb);
    double distance2d = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
    Console.WriteLine("Расстояние между 2 точками в 2D пространстве: " + distance2d);
}
else if (variant == 3)
{
    int xa = new Random().Next(-10, 10); Console.WriteLine("xa:" + xa);
    int ya = new Random().Next(-10, 10); Console.WriteLine("ya:" + ya);
    int za = new Random().Next(-10, 10); Console.WriteLine("za:" + za);
    int xb = new Random().Next(-10, 10); Console.WriteLine("xb:" + xb);
    int yb = new Random().Next(-10, 10); Console.WriteLine("yb:" + yb);
    int zb = new Random().Next(-10, 10); Console.WriteLine("zb:" + zb);
    double distance3d = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    Console.WriteLine("Расстояние между 2 точками в 3D пространстве: " + distance3d);
}
else
{
    Console.WriteLine("Вы ввели неверную цифру - введите 2 или 3");
}
*/

double Dist2(int num)
    {
        int xa = new Random().Next(-10, 10); Console.Write("xa:" + xa + "\t");
        int ya = new Random().Next(-10, 10); Console.Write("ya:" + ya + "\t");
        Console.WriteLine();
        int xb = new Random().Next(-10, 10); Console.Write("xb:" + xb + "\t");
        int yb = new Random().Next(-10, 10); Console.Write("yb:" + yb + "\t");
        Console.WriteLine();
        double dist2 = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
        return dist2;
    }

double Dist3(int num)
    {
        int xa = new Random().Next(-10, 10); Console.Write("xa:" + xa + "\t");
        int ya = new Random().Next(-10, 10); Console.Write("ya:" + ya + "\t");
        int za = new Random().Next(-10, 10); Console.Write("za:" + za + "\t");
        Console.WriteLine();
        int xb = new Random().Next(-10, 10); Console.Write("xb:" + xb + "\t");
        int yb = new Random().Next(-10, 10); Console.Write("yb:" + yb + "\t");
        int zb = new Random().Next(-10, 10); Console.Write("zb:" + zb + "\t");
        Console.WriteLine();
        double dist3 = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
        return dist3;
    }

Console.Write("Введите 2, если ищем в 2D или 3, если ищем в 3D: ");
int n = int.Parse(Console.ReadLine());
if(n == 2)
{
    Console.WriteLine("Расстояние между 2 точками в 2D пространстве: " + Dist2(n));
}
else if(n == 3)
{
    Console.WriteLine("Расстояние между 2 точками в 3D пространстве: " + Dist3(n));
}
else Console.WriteLine("Вы ввели неверную цифру - введите 2 или 3");