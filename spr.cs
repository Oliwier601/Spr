//Zad 2
Console.WriteLine("Podaj liczbę 4 cyfrową");
int a = int.Parse(Console.ReadLine());
int b;
int[]c = new int[4];
int i = 0;
if (a>=1000 && a<=9999)
{
    while (a > 0)
    {
        b = a % 10;
        a /= 10;
        c[i] = b;
        i++;
    }
    if (c[0] == 2*(c[1]) && c[1] == 2 * (c[2])) Console.WriteLine("Ta liczba jest fajna");
    else Console.WriteLine("Ta liczba nie jest fajna");
}
else
{
    Console.WriteLine("To nie jest liczba 4 cyfrowa");
}

//Zad 3
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n-i-1; j++)
    {
        Console.Write(" ");
    }
    for (int j = n-i; j <= i+1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = 0; i < n/2; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Zad 3 odwrócony
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n / 2; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = n; i > 0; i--)
{
    for (int j = n-i-1; j >= 0; j--)
    {
        Console.Write(" ");
    }
    for (int j = i+1; j >= n-i+2; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
