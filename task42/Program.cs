// Определить, сколько чисел больше 0 введено с клавиатуры.

int PositiveCount(string num)
{   
    string[]subnum = num.Split(" ");
    int result = 0;
    int summ = 0;
    foreach (string item in subnum)
    {
        result = Convert.ToInt32(item);
        if(result > 0) summ = summ + 1;
    }
    return summ;
}

Console.Write("Введите пять чисел, отделяя каждое побелом: ");
string entries = Console.ReadLine();
Console.WriteLine("Количество введенных чисел более 0: " + PositiveCount(entries));