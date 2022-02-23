// Написать программу масштабирования фигуры
/* Для тех, кто ушёл далеко вперёд, — усложнение.
Сделать так, чтобы:
1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
3. В результате были выводились полученные координаты.
При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)" */

Console.Write("Введите координаты четырех точек, каждая пара в скобках, отделяя пары пробелом: ");
string entries = Console.ReadLine();
Console.Write("Введите коэффициент масштабирования: ");
double k = double.Parse(Console.ReadLine());
double coordinate = 1; 
char[] separators = new char[] { ' ', ',', ')', '(' };
string[] subentries  = entries.Split(separators, StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < subentries.Length; i++)
{
    coordinate = double.Parse(subentries[i]) * k;
    Console.Write(coordinate );
}
Console.WriteLine();