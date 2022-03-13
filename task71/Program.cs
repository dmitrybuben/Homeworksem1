// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,

// Задача 71 В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

string text = "аисв";
int num = 4;

string[] Alfavit(string text, int n)
{
    if (n == 0) return new string[] { "" };
    string[] mass = Alfavit(text, n - 1);
    string[] result = new string[text.Length * mass.Length];
    int k = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        for (int j = 0; j < text.Length; j++)
        {
            result[k] = mass[i] + text[j];
            k++;
        }
    }
    return result;
}
string[] array = Alfavit(text, num);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}