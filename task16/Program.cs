// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите число от 1 до 7: ");
int daynumber = int.Parse(Console.ReadLine());
if(daynumber == 6) Console.WriteLine("Это суббота! - Выходной!");
else if(daynumber == 7) Console.WriteLine("Это воскресенье! - Выходной");
else Console.WriteLine("Сегодня обычный рабочий день");