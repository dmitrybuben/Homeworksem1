// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool v1 = true;
bool v2 = true;
bool v3 = true;
bool v4 = true;

bool x = true;
bool y = true;
if(!(x||y) == (!x && !y))
{ 
    v1 = true;
}
else
{
    v1 = false;
}

x = false;
y = true;
if(!(x||y) == (!x && !y))
{
    v2 = true;
}
else
{
    v2 = false;
}

x = false;
y = false;
if(!(x||y) == (!x && !y))
{
    v3 = true;
}
else
{
    v3 = false;
}

x = true;
y = false;
if(!(x||y) == (!x && !y))
{
    v4 = true;
}
else
{
    v4 = false;
}

if(v1 && v2 && v3 && v4) Console.WriteLine("Утверждение истинно");
else Console.WriteLine("Утверждение ложно");